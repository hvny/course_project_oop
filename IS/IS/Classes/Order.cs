using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Classes
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public string Status { get; set; } // Статус заказа (например: "Ожидание", "В процессе", "Завершен")
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; } // Например, "Наличные", "Карта"
        public string Device { get; set; } // Устройство, предоставленное на ремонт

        // Поле для хранения выбранных услуг
        public List<Service> Services { get; set; } = new List<Service>();
    }

}
