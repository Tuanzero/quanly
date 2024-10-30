using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class BanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BanController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Ban> Get()
        {
            return _context.Ban.ToList();
        }
    }
}
