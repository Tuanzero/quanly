using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class LoaiMonanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public LoaiMonanController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<LoaiMonan> Get()
        {
            return _context.LoaiMonan.ToList();
        }
    }
}
