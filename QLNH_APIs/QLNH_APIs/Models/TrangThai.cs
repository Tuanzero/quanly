using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class TrangThai
    {
        [Key]
        public int TrangthaiId { get; set; }
        public string TenTrangThai { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
    }
}
