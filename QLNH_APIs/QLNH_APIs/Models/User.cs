using System.ComponentModel.DataAnnotations;
using System.Data;

namespace QLNH_APIs.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool OffDuty { get; set; }
        public virtual VaiTro Vaitro { get; set; }
    }
}
