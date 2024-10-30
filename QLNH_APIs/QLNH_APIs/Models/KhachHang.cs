using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class KhachHang
    {
        [Key]
        public int KhachhangId { get; set; }
        public string Tenkhachhang { get; set; }
        public string Sodienthoai { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }

    }
}
