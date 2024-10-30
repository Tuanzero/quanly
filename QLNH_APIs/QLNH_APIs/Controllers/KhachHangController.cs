using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public KhachHangController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<KhachHang> Get()
        {
            return _context.KhachHang.ToList();
        }
    }
}
