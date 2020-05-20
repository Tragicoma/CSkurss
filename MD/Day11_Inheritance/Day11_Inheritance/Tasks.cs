using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day11_Inheritance
{
    class Tasks
    {
        public List<Employee> employees = new List<Employee>();
        int p = 0, d = 0, m = 0, unidentified = 0;

        public void MakeTeam()
        {
            Console.WriteLine("Time to make a team! Let's start :)");
            Console.WriteLine("Start adding employees... ");
            string input = "";
            while(input!="exit")
            {
                Console.WriteLine("('add'  - to add new emplyee)");
                Console.WriteLine("('submit'  - to submit your team)");
                Console.WriteLine("('exit'   - to leave)");
                Console.WriteLine("---------------------------------------");
                input = Console.ReadLine().ToLower();
                
                switch(input)
                {
                    case "add":
                        AddEmployee();
                        break;
                    case "submit":
                        CountEmployees();
                            if(p >=2 && d>= 1 && m >= 1)
                        {
                            Console.WriteLine("Nice! You have enough employees\n of each proffesion to make a team :) ");
                        }
                            else
                        {
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Not enough employees of the right type:");
                            Console.WriteLine("Programmers: " + p);
                            Console.WriteLine("Data Base Pros: " + d);
                            Console.WriteLine("Managers: " + m);
                            Console.WriteLine("---------------------------------------");
                        }
                          

                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Wrong input.");
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            }
        }
       
        public void AddEmployee()
        {
           
            Console.WriteLine("Please, choose a profession:");
            Console.WriteLine("(1-programmer, 2-databasePRO, 3-Manager)");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Programmer p = new Programmer("Name",0,0,"language");
                    p.EmployeeInfo();
                    Console.Write("PROGRAMMING LANGUAGE: "); 
                    p.SetLanguage(Console.ReadLine());
                    employees.Add(p);
                    break;
                case "2":
                    DataPro d = new DataPro("Name", 0, 0,"tool");
                    d.EmployeeInfo();
                    Console.Write("DATABASE TOOL: ");
                    d.SetTool(Console.ReadLine());
                    employees.Add(d);
                    break;
                case "3":
                    Manager m = new Manager("Name", 0, 0, 0);
                    m.EmployeeInfo();
                    Console.Write("YEARS OF EXPERIENCE: ");
                    try { m.SetExp(Convert.ToInt32(Console.ReadLine())); }
                    catch { Console.WriteLine("Wrong input :( "); }
                    employees.Add(m);
                    break;
                default:
                    break;
            }
        }

        public void CountEmployees()
        {
            p = 0; d = 0; m = 0; unidentified = 0;
            foreach(Employee e in employees)
            {
                if (e.GetType() == typeof(Programmer))
                    p++;
                else if (e.GetType() == typeof(DataPro))
                    d++;
                else if (e.GetType() == typeof(Manager))
                    m++;
                else
                    unidentified++;

            }
        }

    }
}
