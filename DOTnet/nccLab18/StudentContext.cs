using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace nccLab18
{
    //Inherit DbContext
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDbConnection")

        { }


          
        public DbSet<Student> Students { get; set; }
    }

}
