using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab12
{
    public class Program
    {
        //13. Write a C# program to print CustomerId and CustomerName using Dictonary
        static void Main(string[] args)
        {
            Dictionary<int, string> customers = new Dictionary<int, string>();

            customers.Add(101, "Ram");
            customers.Add(102, "Shyam");
            customers.Add(103, "Hari");
            customers.Add(104, "Sita");

            foreach (KeyValuePair<int, string> customer in customers)
            {
                Console.WriteLine("CustomerId: " + customer.Key);
                Console.WriteLine("CustomerName: " + customer.Value);
            }

            Console.ReadKey();
        }
    }
    
}
