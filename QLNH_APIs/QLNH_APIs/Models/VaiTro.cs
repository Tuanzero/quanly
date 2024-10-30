using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class VaiTro
    {
        [Key]
        public int VaitroId { get; set; }
        public string Tenvaitro { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
    }
}
