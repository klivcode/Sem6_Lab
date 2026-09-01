using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab23
{
    public class Program
    {

        // Write a C# program to check whether the given number is a Palindrome or not.
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int original = number;
            int reverse = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number = number / 10;
            }

            if (original == reverse)
                Console.WriteLine("The number is Palindrome.");
            else
                Console.WriteLine("The number is not Palindrome.");
        }
    }
    }

