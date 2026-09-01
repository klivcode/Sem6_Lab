using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab1
{
    public class Program
    {
        // 1. Write a c# program to add two digit using constructor
        // Main Fucntion Entry point of our Project
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1 : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2 : ");
            int b = int.Parse(Console.ReadLine());


            // create Object of class AddTwoNumber

            AddTwoNumber _obj = new AddTwoNumber(a,b);
            Console.WriteLine("Sum of two number: "+ _obj.sum);
            Console.ReadKey();
        }
    }

    public class AddTwoNumber
    {
        public int sum { get; set; }


        // constructor -- adds two digits
        public AddTwoNumber(int num1, int num2)
        {
            sum = num1 + num2;
        }
    }
}
