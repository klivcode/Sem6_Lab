using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab7
{
    public class Program
    {
        // Write C# program how virtual method are used in polymorphism.
        static void Main(string[] args)
        {
            hrDepart obj1 = new hrDepart();
            itDepart obj2 = new itDepart();
            financeDepart obj3 = new financeDepart();

            obj1.LeaderName();
            obj2.LeaderName();
            obj3.LeaderName();
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        public virtual void LeaderName()
        {

        }
    }

    public class itDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr ItDepart");
        }
    }

    public class hrDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr HrDepart");
        }
    }

    public class financeDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr FinanceDepart");
        }
    }
}
