using Infrastructure.Interfaces;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Reposatories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(WakeCapContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Trip>> GetFrequentReserved()
        {
            List<Trip> frequentReserved = null;
            var trips = await _context.Trips.ToListAsync();
            var users = trips.Select(t => t.userEmail).Distinct().ToList();
            if (users.Any())
            {
                frequentReserved = new List<Trip>();
                foreach (var user in users)
                {
                    var shortTripCount = trips.Where(t => t.userEmail == user && t.tripType == 0).Count();
                    var longTripsCount = trips.Where(t => t.userEmail == user && t.tripType == 1).Count();
                    if (shortTripCount > longTripsCount)
                    {
                        var frequTrip = new Trip() { userEmail = user, tripType = 0 };
                        frequentReserved.Add(frequTrip);
                    }
                    else
                    {
                        var frequTrip = new Trip() { userEmail = user, tripType = 1 };
                        frequentReserved.Add(frequTrip);
                    }
                }
            }
            return frequentReserved;
        }

        public async Task<Trip> ReserveTrip(Trip trip)
        {
            if (trip == null || trip?.seats.Count() < 1) return null;

            try
            {
                var reservedSeats = _context.Set<Seat>().Where(s => s.busId == trip.busId && s.isReserved== true).ToList();
                var tripSeats = trip.seats.Select(a => a.name).ToList();
                var reservedSeatsNames = reservedSeats.Select(a => a.name).ToList();

                if (tripSeats.Count() > 20 - reservedSeatsNames.Count())
                {
                    throw new Exception("no capacity in the bus");
                }
                else if (reservedSeatsNames.Intersect(tripSeats).ToList().Any())
                {
                    List<string> duplicatedSeats = reservedSeatsNames.Intersect(tripSeats).ToList();
                    throw new Exception("seat " + String.Join(" ", duplicatedSeats.ToArray()) + " is already reserved");
                }
                var tempSeats = trip.seats;
                trip.seats = null;
                if (tempSeats.Count() <= 5)
                    trip.price = 10 * tempSeats.Count();
                else
                    trip.price = tempSeats.Count()*10 - tempSeats.Count();  // discount one fpr free if more than 5 
                var t = await _context.AddAsync(trip);
                _context.SaveChanges();
                var newTripId = t.Entity.ID;
                var seatsNeedUpdate = _context.Set<Seat>().Where(s => tripSeats.Contains(s.name) && s.busId == trip.busId).ToList();
                if (seatsNeedUpdate.Any())
                {
                    _context.AttachRange(seatsNeedUpdate);
                    seatsNeedUpdate.ToList().ForEach(u =>
                    {
                        u.tripId = newTripId;
                        u.isReserved = true;
                    });
                    _context.UpdateRange(seatsNeedUpdate);
                    trip.seats = seatsNeedUpdate;
                    _context.SaveChanges();
                }
                return t.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
