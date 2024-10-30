using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Tenmonan { get; set; }
        public string Mota { get; set; }
        public double Gia { get; set; }
        public double Giamgia { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
        public virtual LoaiMonan LoaiMonan { get; set; }
        public virtual Donvi Donvi { get; set; }
        public virtual IList<HinhMonan> HinhMonan { get; set; }

    }
}
