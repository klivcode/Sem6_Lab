using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncclab6
{
    public class Program
    {

        // 6. Calculate area of rectangle using multiple inheritance in C#
        static void Main(string[] args)
        {
            //create object
            Rectangle rectangle = new Rectangle();

            rectangle.Display();
            Console.WriteLine("Area of it: "+rectangle.CalculateArea(5, 50));
            Console.ReadKey();
        }
    }

    //Interface Shape
    public interface IShape
    {
        int CalculateArea(int x, int y);
    }

    //Interface Display
    public interface IDisplay
    {
        void Display();
    }

    public class Rectangle : IShape, IDisplay
    {
        public int CalculateArea(int x, int y)
        {
            return x * y;
        }

        public void Display()
        {
            Console.WriteLine("Rectangle");
        }
    }

}
