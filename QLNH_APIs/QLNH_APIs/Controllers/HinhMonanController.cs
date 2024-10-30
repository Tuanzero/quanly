using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{

    public class HinhmonanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HinhmonanController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<HinhMonan> Get()
        {
            return _context.HinhMonan.ToList();
        }
    }
}
