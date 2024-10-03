using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class Order
    {
        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Column("finishedat")]
        public DateTime? FinishedAt { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("totalprice")]
        public decimal TotalPrice { get; set; }

        [Column("paymentmethod")]
        public string PaymentMethod { get; set; }

        [Column("devicename")]
        public string DeviceName { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();
    }
}
