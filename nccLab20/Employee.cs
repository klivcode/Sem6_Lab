using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab20
{
    //Employee Model

    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
