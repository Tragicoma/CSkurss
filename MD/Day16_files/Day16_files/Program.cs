using System;

namespace Day16_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while(input!="0")
            {
                Console.WriteLine("Hello! Please choose one of the following:");
                Console.WriteLine("1 - Add Student to Data base");
                Console.WriteLine("2 - Get list of students");
                Console.WriteLine("0 - Exit application");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Manager.SaveStudent(Manager.AddStudent());
                        break;
                    case "2":
                        Manager.ReadStudentList();
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
