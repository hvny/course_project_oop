using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class Component : IItem
    {
        [Column("component_id")]
        public int ComponentId { get; set; }

        [NotMapped]
        public int Id
        {
            get => ComponentId;
            set => ComponentId = value;
        }


        [Column("name")]
        public string Name { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        public string GetInfo()
        {
            return $"Деталь: {Name}, Quantity: {Quantity}, Price: {Price}";
        }
    }
}
