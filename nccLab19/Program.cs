using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab19
{
    public class Program
    {
        //19. Write Console Application to perform CRUD Operation using ADO.NET in C# having following database and table
        /// <summary>
        /// Database: EmployeeDB
        /// Table : tblEmployee(Id, Name, Age, DOB, Address, Gender)
        /// </summary>
        static string connectionString = @"Data Source=.\SQLEXPRESS;Database=EmployeeDB;Integrated Security = True; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        static void Main(string[] args)
        {


            while (true)
            {

                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Update Data");
                Console.WriteLine("3. Delete Data");
                Console.WriteLine("4. Read Data");

                Console.Write("\n\nEnter your choice: ");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        InsertRecord();
                        break;

                    case 2:
                        UpdateRecord();
                        break;

                    case 3:
                        DeleteRecord();
                        break;

                    case 4:
                        SelectRecord();
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }








        }


        // Create
        static void InsertRecord()
        {

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DOB");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            string gender = Console.ReadLine();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tblEmployee VALUES (@name, @age, @dob, @address, @gender)",
                        conn
                );

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Record Inserted Successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to Insert Record");
                }
            }

        }

        // update
        static void UpdateRecord()
        {

            Console.WriteLine("Enter Id to update");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            string gender = Console.ReadLine();

            Console.WriteLine("DOB");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tblEmployee SET name = @name, age = @age, dob = @dob, address = @address , gender = @gender Where id=@id",
                        conn
                );

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);



                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Record Inserted Successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to Insert Record");
                }
            }

        }


        // Delete
        static void DeleteRecord()
        {

            Console.Write("Enter Student ID to delete: ");
            int id = int.Parse(Console.ReadLine());


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM tblEmployee WHERE id = @id",
                            conn
                        );

                cmd.Parameters.AddWithValue("@id", id);
            }


        }


        // Read
        static void SelectRecord()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "Select * from tblEmployee",
                            conn
                        );

                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("\nId\tName\tAge\tDob\tGender");
                Console.WriteLine("________________________________________________________________________");

                while (reader.Read())
                {
                    Console.WriteLine(reader["Id"] + "\t" + reader["Name"] + "\t" + reader["Age"] + "\t" + reader["DOB"] + "\t" + reader["Gender"]);

                }
            }



        }
    }
}

