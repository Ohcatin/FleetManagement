using Microsoft.EntityFrameworkCore;
using FleetManagement.Models;

namespace FleetManagement.Data
{
    public class TaxiContext : DbContext
    {
        public TaxiContext(DbContextOptions<TaxiContext> options) : base(options) { }

        public DbSet<Taxi> Taxis { get; set; }
    }
}
