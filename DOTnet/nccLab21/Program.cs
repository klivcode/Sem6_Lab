using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab21
{
    // Write a C# program to demonstrate Method Overloading.
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Sum of two integers: " + calculator.Add(10, 20));
            Console.WriteLine("Sum of three integers: " + calculator.Add(10, 20, 30));
            Console.WriteLine("Sum of two double values: " + calculator.Add(10.5, 20.5));
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
