using Day9_ListsOfObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day16_files
{
    class Manager
    {

        public static Student AddStudent()
        {
            Console.WriteLine("Student Name:");
            string n = Console.ReadLine();
            Console.WriteLine("Student Surname:");
            string s = Console.ReadLine();
            Console.WriteLine("Student Course(1-3):");
            int c = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(n,s,c);
            return student;
        }

        public static void SaveStudent(Student student)
        {
            try
            {
                string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList";
                List<string> info = new List<string>();
                info.Add(student.getName());
                info.Add(student.getSurname());
                info.Add(student.getCourse().ToString());
                info.Add("---");
                StreamWriter sw = new StreamWriter(@"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList", true);
                foreach (string s in info)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("I wasn't able to write to the file...");
                Console.WriteLine(e);

            }
        }

        public static void ReadStudentList()
        {
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList";
            StreamReader sr = new StreamReader(fp);
            string line = sr.ReadLine();
            Console.WriteLine("-------------------");
            while (line != null)
            {
                Console.WriteLine(line);

                line = sr.ReadLine();
            }
            Console.WriteLine("-------------------");

            sr.Close();
        }
    }
}
