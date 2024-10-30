using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Sodonhang { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public double Tonggia { get; set; }
        public double Tienthanhtoan { get; set; }
        public virtual IList<OrderItem> OrderItem { get; set; }


    }
}
