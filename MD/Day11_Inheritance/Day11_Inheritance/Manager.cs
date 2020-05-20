using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_Inheritance
{
    class Manager :  Employee
    {
        protected int ExpYears;

        public Manager(string name, int age, double wage, int exp)
        {
            this.Name = name;
            this.Age = age;
            this.Wage = wage;
            this.ExpYears = exp;
        }

        public void SetExp(int exp)
        {
            this.ExpYears = exp;
        }

        public void Print()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("AGE: " + Age);
            Console.WriteLine("WAGE: " + Wage);
            Console.WriteLine("EXPERIENCE: " + ExpYears + "years");
        }
    }
}
