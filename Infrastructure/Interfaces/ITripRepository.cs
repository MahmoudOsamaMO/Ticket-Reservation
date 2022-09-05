using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ITripRepository : IGenericRepository<Trip>
    {
        Task<IEnumerable<Trip>> GetFrequentReserved();
        Task<Trip> ReserveTrip(Trip trip);

    }
}
