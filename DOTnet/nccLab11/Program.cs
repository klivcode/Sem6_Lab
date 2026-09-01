using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab11
{
    public class Program
    {
        // 11. Write a C# program to print 1 to 10 using generic List
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // Add numbers 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            // Print numbers
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}

