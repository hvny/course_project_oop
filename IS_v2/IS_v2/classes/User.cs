using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class User
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("phonenumber")]
        public string PhoneNumber { get; set; }

        [Column("name")]
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
