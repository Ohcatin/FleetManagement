using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FleetManagement.Data;
using FleetManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxisController : ControllerBase
    {
        private readonly TaxiContext _context;

        public TaxisController(TaxiContext context)
        {
            _context = context;
        }

        // GET: api/taxis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Taxi>>> GetTaxis(int pageNumber = 1, int pageSize = 10)
        {
            var taxis = await _context.Taxis
                                      .Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToListAsync();
            return Ok(taxis);
        }
    }
}
