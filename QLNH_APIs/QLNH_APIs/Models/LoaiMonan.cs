using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class LoaiMonan
    {
        [Key]
        public int LoaiMonanId { get; set; }
        public int parentId { get; set; }
        public string Tenloai { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
    }
}
