using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab15
{
    public class Program
    {
        //15. Write a C# program to sort given name using LINQ
        // a. Ram,Shyam,Hari,Bikash,Mahesh
        static void Main(string[] args)
        {
            string[] names = { "Ram", "Shyam", "Hari", "Bikash", "Mahesh" };

            var sortedNames = names.OrderBy(name => name);

            Console.WriteLine("Names in Sorted Order:");

            foreach (string name in sortedNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
