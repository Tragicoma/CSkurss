using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_Inheritance
{
    class Programmer : Employee
    {
        protected string Language;

        public Programmer(string name, int age, double wage, string language)
        {
            this.Name = name;
            this.Age = age;
            this.Wage = wage;
            this.Language = language;
        }

        public void SetLanguage(string language)
        {
            this.Language = language;
        }
        public void GetLanguage()
        {

        }

        public void Print()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("AGE: " + Age);
            Console.WriteLine("WAGE: " + Wage);
            Console.WriteLine("LANGUAGE: "+ Language);
        }
    }
}
