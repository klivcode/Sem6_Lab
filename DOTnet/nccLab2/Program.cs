using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab2
{
    public class Program
    {
        //2.  write a C# program to display student Id and Name using automatic properties
        // Main Fucntion -- Entry Point
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Id: ");
            int a = int.
                Parse(Console.ReadLine());


            Console.WriteLine("Enter name: ");
            string b = Console.ReadLine();

            Student _student = new Student();
            _student.StudentId = a;
            _student.Name = b;
            Console.WriteLine("Value StudntId and Name : " + _student.StudentId + "\tAnd\t" + _student.Name);
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

    }

}
