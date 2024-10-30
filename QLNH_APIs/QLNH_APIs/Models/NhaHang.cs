using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class NhaHang
    {
        [Key]
        public int NhaHangId { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public String Sodienthoai  { get; set; }
        public String Diachi  { get; set; }
    }
}
