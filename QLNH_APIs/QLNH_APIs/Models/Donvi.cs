using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class Donvi
    {
        [Key]
        public int DonviId { get; set; }
        public string TenDonvi { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
        public Loaidonvi Loaidonvi { get; set; }
    }
}
