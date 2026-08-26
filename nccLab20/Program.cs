using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace nccLab20
{

    //20. Write Console Application to perform CRUD Operation using EntityFramework in C# having following database and table
    /// <summary>
    /// Database: EmployeeDB
    /// Table : tblEmployee(Id, Name, Age, DOB, Address, Gender)
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("   CRUD Operations (Entity Framework)");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Create (Insert)");
                Console.WriteLine("2. Read (Select)");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Insert(); break;
                    case 2: Select(); break;
                    case 3: Update(); break;
                    case 4: Delete(); break;
                    case 5: return;
                }
            }

        }

        static void Insert()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter DOB: ");
            string dob = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();
            

            using (var context = new EmployeeContext())
            {
                Employee e = new Employee
                {
                    Name = name,
                    Age = age,
                    DOB = dob,
                    Address = address,
                    Gender = gender

                };
                context.Employees.Add(e);
                context.SaveChanges();
                Console.WriteLine("Record inserted successfully.");
            }
        }

        static void Select()
        {
            using (var context = new EmployeeContext())
            {
                var employees = context.Employees.ToList();
                Console.WriteLine("Id\tName\tAge\tGender");
                Console.WriteLine("------------------------------------------");
                foreach (var e in employees)
                {
                    Console.WriteLine(e.Id + "\t" + e.Name + "\t" + e.Age+"\t"+e.Gender);
                }
            }
        }

        static void Update()
        {
            Select();
            Console.Write("Enter Id to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new EmployeeContext())
            {
                var employee = context.Employees.Find(id);
                if (employee != null)
                {
                    Console.Write("Enter new Name: ");
                    employee.Name = Console.ReadLine();
                    Console.Write("Enter new Age: ");
                    employee.Age = int.Parse(Console.ReadLine());
                    context.SaveChanges();
                    Console.WriteLine("Record updated.");
                }
                else
                {
                    Console.WriteLine("Record not found.");
                }
            }
        }

        static void Delete()
        {
            Select();
            Console.Write("Enter Id to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new EmployeeContext())
            {
                var employee = context.Employees.Find(id);
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                    Console.WriteLine("Record deleted.");
                }
                else
                {
                    Console.WriteLine("Record not found.");
                }
            }
        }
    }
}



