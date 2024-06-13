using Microsoft.EntityFrameworkCore;
using FleetManagement.Models;

namespace FleetManagement.Data
{
    public class TaxiContext : DbContext
    {
        public TaxiContext(DbContextOptions<TaxiContext> options) : base(options) { }

        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxi>().ToTable("taxis"); // Asegúrate de que el nombre de la tabla está en minúsculas
        }
    }
}
