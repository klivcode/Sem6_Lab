using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab9
{
    public class Program
    {
        // 9. Write C# program to Add, Subtract, Multiply, Divide using OOP
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int a = 20;
            int b = 5;

            Console.WriteLine("Addition: " + calculator.Add(a, b));
            Console.WriteLine("Subtraction: " + calculator.Subtract(a, b));
            Console.WriteLine("Multiplication: " + calculator.Multiply(a, b));
            Console.WriteLine("Division: " + calculator.Divide(a, b));

            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
