using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class DeliveryComponent
    {
        [Column("delivery_component_id")]
        public int DeliveryComponentId { get; set; }

        [Column("component_id")]
        public int ComponentId { get; set; }

        public Component Component { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("delivery_id")]
        public int DeliveryId { get; set; }
    }
}
