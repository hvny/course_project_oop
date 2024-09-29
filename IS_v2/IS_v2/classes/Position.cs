using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class Position
    {
        [Column("position_id")]
        public int PositionId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("salary")]
        public decimal Salary { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
