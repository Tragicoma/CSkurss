using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Day17_JSON
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = "";

            while (input != "0")
            {
                Console.WriteLine("Hello! Please choose one of the following:");
                Console.WriteLine("1 - Add Student to Data base");
                Console.WriteLine("2 - Get list of students");
                Console.WriteLine("0 - Exit application");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        FileManager.AddStudent(students);
                        FileManager.WriteList(students);
                        break;
                    case "2":
                        FileManager.PrintList();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Try again...");
                        break;

                }

            }
        }
    }
}
