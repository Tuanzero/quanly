using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class Loaidonvi
    {
        [Key]
        public int LoaidonviId { get; set; }
        public string Tenloai { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
    }
}
