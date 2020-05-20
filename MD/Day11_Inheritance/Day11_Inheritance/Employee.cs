using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day11_Inheritance
{
    public class Employee
    {
        protected string Name;
        protected int Age;
        protected double Wage;

        
        public void EmployeeInfo()
        {
            Console.WriteLine("Please, type in information about the new employee: ");
            Console.Write("NAME: "); this.Name = Console.ReadLine();
            Console.Write("AGE: "); this.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("WAGE: ");
            try { this.Wage = Convert.ToDouble(Console.ReadLine()); }
            catch { Console.WriteLine("Wrong input :( "); }

        }

        
    }
}
