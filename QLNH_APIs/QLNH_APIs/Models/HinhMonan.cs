using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class HinhMonan
    {
        [Key]
        public int HinhMonanId { get; set; }
        public string Ten { get; set; }
        public string Data { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
    }
}
