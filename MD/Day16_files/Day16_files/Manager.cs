using Day9_ListsOfObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            if(n.Length>1 && s.Length>1 && c>0 && c<4)
            {
                Student student = new Student(n, s, c);
                return student;
            }
            else
            {
                Console.WriteLine("Wrong input...");
                return null;
            }
            
        }

        public static void SaveStudent(Student student)
        {
            try
            {
                string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList.txt";
                string[] info = new string[3];
                info[0] = student.getName();
                info[1] = student.getSurname();
                info[2] = student.getCourse().ToString();
                StreamWriter sw = new StreamWriter(fp, true);
                sw.Write(info[0] + ",");
                sw.Write(info[1] + ",");
                sw.Write(info[2]);
                sw.Write("\n");
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
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList.txt";
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

        public static void RemoveStudent()
        {
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList.txt";
            List<Student> students = OpenStudentList();
            Console.WriteLine("Choose index of the student you would like to remove or edit:");
            Console.WriteLine("Index:");
            try
            { 
                int input = Convert.ToInt32(Console.ReadLine());
                students.Remove(students[input]);
                SaveListFile(students, fp);
            }
            catch
            { Console.WriteLine("Couldn't find that index..."); }
            
            
        }
        public static void EditStudent()
        {
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList.txt";
            List<Student> students = OpenStudentList();
            Console.WriteLine("Please, choose a student by selecting their index:");
            try
            { 
                int input = Convert.ToInt32(Console.ReadLine());
                students[input].print();
                Console.WriteLine("Type in new data:");
                students[input] = AddStudent();
                SaveListFile(students, fp);
            } 
            catch
            { Console.WriteLine("Couldn't find that index..."); }
            
        }
        
        public static void FindCourse()
        {
            List<Student> students = OpenStudentList();
            Console.WriteLine("Please, which course are we looking for?");
            string input = Console.ReadLine();
            foreach(Student s in students)
            {
                try
                {
                    string course = s.getCourse().ToString();
                    if (course == input)
                    {
                        s.print();
                    }
                }
                catch
                { Console.WriteLine("No  such course..."); }
            }
        }
        private static List<Student> OpenStudentList()
        {
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day16_files\StudentList.txt";

            
            List<string> list = File.ReadAllText(fp).Split("\n").ToList();

            int index = -1;
            List<Student> students = new List<Student>();
            foreach (string s in list)
            {
                index++;
                Console.WriteLine($"({index})" + s);
                string[] studentData = s.Split(",");
                if (studentData[0] != "")
                    students.Add(new Student(studentData[0], studentData[1], Convert.ToInt32(studentData[2])));
            }
            return students;
        }
         private static void SaveListFile(List<Student> stList,string fp)
        {
            try
            {
                File.WriteAllText(fp, String.Empty);
                foreach (Student st in stList)
                {
                    SaveStudent(st);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Couldn't save to file...");
            }
        }
        
    }

}
