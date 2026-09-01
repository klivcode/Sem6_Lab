using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab8
{
    public class Program
    {

        static void Main(string[] args)
        {
            DelegatesAdd obj = new DelegatesAdd();

            // Create delegate and point it to AddMethod()
            addMethod add = obj.AddMethod;

            // Invoke delegate
            add();

            Console.ReadKey();
        }
    }


    // Delegate
    public delegate void addMethod();

    public class DelegatesAdd
    {
        public void AddMethod()
        {
            int a = 10;
            int b = 20;

            int sum = a + b;

            Console.WriteLine("Sum: " + sum);
        }
    }
}
