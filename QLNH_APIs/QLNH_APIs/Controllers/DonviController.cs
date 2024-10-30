using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class DonviController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DonviController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Donvi> Get()
        {
            return _context.Donvi.ToList();
        }
    }
}
