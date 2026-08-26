using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab20
{
    //Inheirt DbContext
    public class EmployeeContext : DbContext
    {
        //constructor
        public EmployeeContext() : base("EmployeeDbConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
