using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Classes
{
    class Student
    {
        private static string name;
        private static string surname;
        private static int course;

        public static void SetName(string n)
        {
            name = n.ToUpper();
        }
        public static void SetSurname(string sn)
        {
            surname = sn.ToUpper();
        }
        public static void SetCourse(int c)
        {
            if(c!=1 && c!=2 && c!=3)
            {
                Console.WriteLine("Wrong input! Please, enter course 1, 2 or 3! \n Try again...");
                Program.StudentForm();
            } 
            else
            course = c;
        }

        public static void Print()
    {
        Console.WriteLine("Students name: " + name);
        Console.WriteLine("Students surname: " + surname);
        Console.WriteLine("Students course: " + course);
    }

}

    
}
