using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FleetManagement.Data;
using FleetManagement.Models;
using System.Linq;
using System.Threading.Tasks;

namespace FleetManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly TaxiContext _context;

        public LocationsController(TaxiContext context)
        {
            _context = context;
        }

        [HttpGet("taxi/{taxiId}/date/{date}")]
        public async Task<IActionResult> GetLocationsByTaxiIdAndDate(int taxiId, DateTime date, int pageNumber, int pageSize)
        {
            date = DateTime.SpecifyKind(date, DateTimeKind.Utc); // DateTimeKind sea UTC
            var locations = await _context.Locations
                .Where(l => l.TaxiId == taxiId && l.Date == date)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            if (locations == null || locations.Count == 0)
            {
                return NotFound();
            }

            return Ok(locations);
        }

    }
}
