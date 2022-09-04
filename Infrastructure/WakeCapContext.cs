using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
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
                busId = "bus1",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 1,
            });
            trips.Add(new Trip
            {
                ID = 4,
                busId = "bus1",
                userEmail = "Yehia@gmail.com",
                price = 10,
                tripType = 1,
            });
            trips.Add(new Trip
            {
                ID = 5,
                busId = "bus1",
                userEmail = "Yehia@gmail.com",
                price = 10,
                tripType = 1,
            });
            modelBuilder.Entity<Trip>().HasData(trips);

        }
    }
}