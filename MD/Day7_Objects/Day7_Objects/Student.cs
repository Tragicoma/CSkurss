using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Objects
{
    class Student
    {
        private string name;
        private string surname;
        private int course;

        public Student(string name, string surname, int course)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;

        }
        public void SetName(string n)
        {
            name = n.ToUpper();
        }
        public void SetSurname(string sn)
        {
            surname = sn.ToUpper();
        }
        public void SetCourse(int c)
        {
            if (c != 1 && c != 2 && c != 3)
            {
                Console.WriteLine("Wrong input! Please, enter course 1, 2 or 3! \n Try again...");
                Program.StudentForm();
            }
            else
                course = c;
        }

        public void Print()
        {
            Console.WriteLine("Students name: " + name);
            Console.WriteLine("Students surname: " + surname);
            Console.WriteLine("Students course: " + course);
        }

    }
}
