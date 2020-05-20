using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_Inheritance
{
    class DataPro : Employee
    {
        protected string DatabaseTool;

        public DataPro(string name, int age, double wage, string tool)
        {
            this.Name = name;
            this.Age = age;
            this.Wage = wage;
            this.DatabaseTool = tool;
            
        }

        public void SetTool(string tool)
        {
            this.DatabaseTool = tool;
        }

        public void Print()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("AGE: " + Age);
            Console.WriteLine("WAGE: " + Wage);
            Console.WriteLine("TOOL: " + DatabaseTool);
        }
    }
}
