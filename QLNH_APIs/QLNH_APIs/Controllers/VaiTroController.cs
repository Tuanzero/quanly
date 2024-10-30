using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;
using System.Data;

namespace QLNH_APIs.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class VaiTroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public VaiTroController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<VaiTro> Get()
        {
            return _context.VaiTro.ToList();
        }

        /// <summary>
        /// Lấy Role với Id
        /// </summary>
        /// <returns>Danh sách Role</returns>
        /// <param name="Id">Tham số là Id của Role</param>
        [HttpGet("Id")]
        public VaiTro Get([FromQuery] int Id)
        {
            return _context.VaiTro.Where(VaiTro => VaiTro.VaitroId == Id).FirstOrDefault();
        }

        /// <summary>
        /// Thêm Role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public VaiTro Post([FromQuery] VaiTro VaiTro)
        {
            _context.VaiTro.Add(VaiTro);
            _context.SaveChanges();
            return VaiTro;
        }
    }
}
