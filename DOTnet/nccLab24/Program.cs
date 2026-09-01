using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab24
{
    public class Program
    {

        // Write a C# program to demonstrate the use of Abstract Class and Abstract Method
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Area();
        }
    }


    abstract class Shape
    {
        public abstract void Area();
    }

    class Rectangle : Shape
    {
        public int length = 10;
        public int breadth = 5;

        public override void Area()
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
