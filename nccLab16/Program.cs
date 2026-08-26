using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab16
{
    public class Program
    {
        //16. Write a C# Program using async and wait for long process   
        static async Task Main(string[] args)
        {
            Console.WriteLine("Process Started...");

            await LongProcess();

            Console.WriteLine("Process Completed.");

            Console.ReadKey();
        }

        public static async Task LongProcess()
        {
            Console.WriteLine("Long process is running...");

            // Simulate a long-running process
            await Task.Delay(5000);

            Console.WriteLine("Long process finished.");
        }
    }
}
