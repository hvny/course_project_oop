using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class Warehouse
    {
        [Column("warehouse_id")]

        public int WarehouseId { get; set; }

        [Column("name")]
        public string Name { get; set; }
        public List<Component> Components { get; set; }
        public Warehouse()
        {
            Components = new List<Component>();
        }
    }
}
