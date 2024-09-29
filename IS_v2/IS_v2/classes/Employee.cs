using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.classes
{
    public class Employee
    {
        [Column("employee_id")]
        public int employeeId { get; set; }

        [Column("position_id")]
        public int PositionId { get; set; }

        [Column("name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
