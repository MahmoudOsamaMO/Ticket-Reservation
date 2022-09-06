using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Infrastructure
{
    public class WakeCapContext : DbContext
    {
        public WakeCapContext(DbContextOptions<WakeCapContext> options) : base(options)
        {
        }
        public DbSet<Trip> Trips { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedTrips(modelBuilder);
            SeedSeats(modelBuilder);
        }

        public void SeedTrips(ModelBuilder modelBuilder)
        {
            List<Trip> trips = new List<Trip>();
            trips.Add(new Trip
            {
                ID = 1,
                busId = "bus1",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 0,
            });
            trips.Add(new Trip
            {
                ID = 2,
                busId = "bus1",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 0,
            });
            trips.Add(new Trip
            {
                ID = 3,
                busId = "bus2",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 1,
            });
            trips.Add(new Trip
            {
                ID = 4,
                busId = "bus2",
                userEmail = "Yehia@gmail.com",
                price = 10,
                tripType = 1,
            });
            trips.Add(new Trip
            {
                ID = 5,
                busId = "bus2",
                userEmail = "Yehia@gmail.com",
                price = 10,
                tripType = 1,
            });
            modelBuilder.Entity<Trip>().HasData(trips);
        }

        private void SeedSeats(ModelBuilder modelBuilder)
        {
            List<Seat> seats = new List<Seat>();
            seats.Add(new Seat
            {
                busId = "bus1",
                seatId = 1,
                name = "A01",
                isReserved = true,
                tripId = 1,
            });
            seats.Add(new Seat
            {
                busId = "bus1",
                seatId = 2,
                name = "A02",
                isReserved = true,
                tripId = 1,
            });
            for(int i = 3; i < 10; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus1",
                    seatId = i,
                    name = "A0"+i.ToString(),
                    isReserved = true,
                    tripId = 2,
                });
            }
            for (int i = 10; i <= 20; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus1",
                    seatId = i,
                    name = "A" + i.ToString(),
                    isReserved = false,
                    tripId = null,
                });
            }
            for (int i = 0; i <= 9; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus2",
                    seatId = i+21,
                    name = "A0" + i.ToString(),
                    isReserved = false,
                    tripId = null,
                });
            }
            for (int i = 10; i <= 20; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus2",
                    seatId = i + 21,
                    name = "A" + i.ToString(),
                    isReserved = false,
                    tripId = null,
                });
            }
            modelBuilder.Entity<Seat>().HasData(seats);
        }
    }
}