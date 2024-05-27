using Microsoft.EntityFrameworkCore;
using FleetManagement.Models;

namespace FleetManagement.Data
{
    public class ApplicationDbContext : DbContext   
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Trajectory> Trajectories { get; set; }
    }
}
