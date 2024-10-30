using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class TrangThaiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TrangThaiController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<TrangThai> Get()
        {
            return _context.TrangThai.ToList();
        }
    }
}
