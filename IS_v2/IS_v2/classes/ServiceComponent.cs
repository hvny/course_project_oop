using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class ServiceComponent
    {
        [Column("service_component_id")]
        public int ServiceComponentId { get; set; }

        [Column("service_id")]
        public int ServiceId { get; set; }  

        [Column("component_id")]
        public int ComponentId { get; set; } 

        [Column("quantity")]
        public int Quantity { get; set; } 

        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }

        [ForeignKey("ComponentId")]
        public virtual Component Component { get; set; }
    }
}
