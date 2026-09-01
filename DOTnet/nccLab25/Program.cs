using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab25
{
    public class Program
    {
        // Write a C# program to demonstrate Exception Handling using try, catch, and finally blocks.
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers.");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        
    }
    }
}
