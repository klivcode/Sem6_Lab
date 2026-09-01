using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab4
{
    // 4. write a C# program how Name of students are stored and retrieved using indexer.
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //Storing the Values using Indexer
            for(int i =0; i<5;i++)
            {
                Console.Write("Enter Name of Student " + (i + 1) + "\n");
                student[i]=Console.ReadLine();
            }

            // Retrieve Values using Indexer
            Console.WriteLine("Students Name:\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " Name: " + student[i]);
            }

        }
    }

    public class Student
    {
        private string[] names = new string[5];
        // Indexer
        public string this [int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }
}
