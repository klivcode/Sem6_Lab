using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab13
{
    public class Program
    {
        //13. Write a C# program to print DriveInfo, TotalSize, VolumeLabel of Drive
        static void Main(string[] args)
        {

            DriveInfo drive = new DriveInfo("C");

            Console.WriteLine("Drive Name: " + drive.Name);
            Console.WriteLine("Total Size: " + drive.TotalSize);
            Console.WriteLine("Volume Label: " + drive.VolumeLabel);

            Console.ReadKey();
        }
    }
}
