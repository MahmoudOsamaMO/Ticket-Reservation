using Infrastructure.Interfaces;
using Infrastructure.Models;
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
        public IEnumerable<Trip> GetFrequentReserved()
        {
            List<Trip> frequentReserved = null;
            var trips = _context.Trips.ToList();
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
    }
}
