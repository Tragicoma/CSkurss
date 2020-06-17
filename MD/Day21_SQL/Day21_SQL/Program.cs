using MySqlX.XDevAPI;
using System;

namespace Day21_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            NewEmployee();
        }

        static void NewEmployee()
        {
            DBConnection DBC = new DBConnection();
            DBC.Connect();
            Console.WriteLine("Let's add a new employee...");
            Console.WriteLine("Employee name:");
            string name = Console.ReadLine();
            Console.WriteLine("Employee Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Department ID:");
            string dId = Console.ReadLine();
            Console.WriteLine("Employee job ID:");
            string id =Console.ReadLine();
            Console.WriteLine("Employee Salary:");
            string salary = Console.ReadLine();
            DBC.AddEmployee(name, surname, dId, id, salary);
        }
        

    }
}
