using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab14
{
    public class Program
    {
        //14. Write a C# program to Read, Write, Delete, Move, Create a File using File.IO
        static void Main(string[] args)
        {

            // File location
            string fileLocation = @"C:\Users\klivcode\sample.txt";

            // New file location for moving
            string newFileLocation = @"C:\Users\klivcode\sample_moved.txt";

            // Create object
            CF cf = new CF();

            Console.WriteLine("Checking File");

            // Creating File
            cf.CreateFile(fileLocation);

            // Get text from user
            Console.Write("Enter the text: ");
            string inText = Console.ReadLine();

            // Writing in File
            Console.WriteLine("Writing in process...");
            cf.WritingFile(fileLocation, inText);

            // Reading File
            Console.WriteLine("\n\nReading the Text:");
            cf.ReadingFile(fileLocation);

            // Moving File
            Console.WriteLine("\nMoving File...");
            cf.MoveFile(fileLocation, newFileLocation);

            // Deleting File
            Console.WriteLine("\nDeleting File...");
            cf.DeleteFile(newFileLocation);

            Console.ReadKey();
        }
    }

    // Class CF
    public class CF
    {
        FileStream fileStream = null;

        // Create File Method
        public void CreateFile(string fileLoc)
        {
            // Check if file does not exist
            if (!File.Exists(fileLoc))
            {
                using (FileStream fileStream = File.Create(fileLoc))
                {
                    Console.WriteLine("File Created Successfully");
                }
            }
            else
            {
                Console.WriteLine("File Already Exists");
            }
        }


        // Writing in File Method
        public void WritingFile(string fileLoc, string inData)
        {
            // Check File
            if (File.Exists(fileLoc))
            {
                using (StreamWriter sw = new StreamWriter(fileLoc))
                {
                    sw.Write(inData);
                }

                Console.WriteLine("Writing Successful");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }


        // Reading File Method
        public void ReadingFile(string fileLoc)
        {
            if (File.Exists(fileLoc))
            {
                using (StreamReader sr = new StreamReader(fileLoc))
                {
                    string data = sr.ReadToEnd();
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }


        // Moving File Method
        public void MoveFile(string oldLocation, string newLocation)
        {
            if (File.Exists(oldLocation))
            {
                File.Move(oldLocation, newLocation);

                Console.WriteLine("File Moved Successfully");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }


        // Delete File Method
        public void DeleteFile(string fileLoc)
        {
            if (File.Exists(fileLoc))
            {
                File.Delete(fileLoc);

                Console.WriteLine("File Deleted Successfully");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }

    }
}
