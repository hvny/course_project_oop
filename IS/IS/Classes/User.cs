using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Список для хранения истории заказов пользователя
        public List<Order> OrderHistory { get; set; } = new List<Order>();
    }
}
