using Infrastructure.Interfaces;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
            var users = trips.Select(t=>t.userEmail).Distinct().ToList();
            if (users.Any())
            {
                frequentReserved = new List<Trip>();
                foreach(var user in users)
                {
                    var shortTripCount = trips.Where(t => t.userEmail == user && t.tripType == 0).Count();
                    var longTripsCount = trips.Where(t => t.userEmail == user && t.tripType == 1).Count();
                    if(shortTripCount > longTripsCount)
                    {
                        var frequTrip = new Trip() { userEmail = user , tripType = 0 };
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
            var t = await _context.AddAsync(trip);
            return t.Entity;
        }
    }
}
