using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IS_v2.classes
{
    public class Delivery
    {
        [Column("delivery_id")]
        public int DeliveryId { get; set; }

        [Column("date")]
        public DateTime DeliveryDate { get; set; }

        [Column("status")]
        public string Status { get; set; }

        public ICollection<DeliveryComponent> DeliveryComponents { get; set; }
    }
}
