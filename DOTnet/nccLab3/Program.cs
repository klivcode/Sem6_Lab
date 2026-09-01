using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab3
{

    // 3. write a C# program to reverse element of an array .
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n :");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Original Array :  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");

            }


            // Reverse array
            Array.Reverse(arr);


            Console.WriteLine("\nReverse Array :  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");

            }

        }
    }


}
