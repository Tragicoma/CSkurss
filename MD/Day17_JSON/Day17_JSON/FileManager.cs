using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day17_JSON
{
    class FileManager
    {
        public static string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day17_JSON\students.json";
        public static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Student Name:");
            string n = Console.ReadLine();
            Console.WriteLine("Student Surname:");
            string s = Console.ReadLine();
            Console.WriteLine("Student Course(1-3):");
            int c = Convert.ToInt32(Console.ReadLine());
            Student student;
            if (n.Length > 1 && s.Length > 1 && c > 0 && c < 4)
            {
                student = new Student(n, s, c);
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Wrong input...");
                
            }
        }


        public static void WriteList(List<Student> students)
        {
            try
            {
                String json = JsonConvert.SerializeObject(students);
                File.WriteAllText(fp, json);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        public static List<Student> GetList()
        {
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(fp));
            return students;
        }
        public static void PrintList()
        {
            List<Student> list = GetList();
            foreach(Student s in list)
            {
                s.print();
            }
        }


    }
}
