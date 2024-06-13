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

        [HttpGet]
        public async Task<IActionResult> ListTaxis(int pageNumber, int pageSize)
        {
            List<Taxi> ListTaxi = await _context.Taxis.Skip((pageNumber - 1) * pageSize)
           .Take(pageSize).ToListAsync();

            return Ok(ListTaxi);
        }
    }
}
