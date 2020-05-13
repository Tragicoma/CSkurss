using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_ListsOfObjects
{
    class Task
    {
        List<Student> list = new List<Student>();
        public void Task1()
        {
            
            string input = "";
            while(input!="0")
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - print student list");
                Console.WriteLine("2 - add a new student to the list");
                Console.WriteLine("0 - exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PrintList();
                        break;
                    case "2":
                        AddStudent();
                        break;
                    case "0":
                        break;
                    default:
                        break;

                }
            }

        }

        public void AddStudent()
        {
            Console.WriteLine("Please, write name, surname and course: ");
            list.Add(new Student(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
        }
        public void PrintList()
        {
            foreach(Student st in list)
            {
                st.print();
            }
        }
    }
}
