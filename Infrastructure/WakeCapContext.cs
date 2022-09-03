using ApplicationCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class WakeCapContext : DbContext
    {
        public WakeCapContext(DbContextOptions<WakeCapContext> options) : base(options)
        {
        }
        public DbSet<Trip> Trips { get; set; } = null!;

    }
}