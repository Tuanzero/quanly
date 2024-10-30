using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public String NgayTao { get; set; }
        public String NgayCapNhat { get; set; }
        public bool Xoa { get; set; }
        public bool Vohieu { get; set; }
        public double Giaban { get; set; }
        public virtual Item Item { get; set; }
    }
}
