using Org.BouncyCastle.Bcpg;
using System;

namespace Day21_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            DBStuff DB = new DBStuff();
            DB.Connect();
            DB.GetStudents();
            //EnterStudent(DB);
            DeleteStudent(DB);
        }

        public static void EnterStudent(DBStuff DB)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your Course:");
            int course = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(name, surname, course);
            DB.AddStudent(student);
        }

        public static void DeleteStudent(DBStuff DB)
        {
            Console.WriteLine("Enter the ID of the student you wish to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            DB.DeleteById(id);
        }
    }
}
