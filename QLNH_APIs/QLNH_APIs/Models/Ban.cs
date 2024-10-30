using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class Ban
    {
        [Key]
        public int BanId { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
        public virtual TrangThai Trangthai { get; set; }
        public virtual KhachHang Khachhang { get; set; }

    }
}
