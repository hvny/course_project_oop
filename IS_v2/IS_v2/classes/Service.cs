using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class Service
    {
        [Column("service_id")]
        public int ServiceId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        public ICollection<ServiceComponent> ServiceComponents { get; set; } = new List<ServiceComponent>();
    }

}
