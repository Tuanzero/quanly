using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class NhaHangController : ControllerBase
    {       
        private readonly ApplicationDbContext _context;
        public NhaHangController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<NhaHang> Get()
        {
            return _context.NhaHang.ToList();
        }
    }
}
