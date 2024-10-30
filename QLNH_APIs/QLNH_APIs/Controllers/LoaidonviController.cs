using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class LoaidonviController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public LoaidonviController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Loaidonvi> Get()
        {
            return _context.Loaidonvi.ToList();
        }
    }
}
