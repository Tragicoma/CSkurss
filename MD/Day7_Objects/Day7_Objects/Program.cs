using System;
using System.Collections.Generic;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine("Add words to the list(type 'stop' to get list");
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "stop")
                    break;
                list.Add(input);
                

            }
            Console.WriteLine();
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }

        }
        public static void StudentForm()
        {
            Console.WriteLine("Enter student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student's surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter student's course(1-3): ");
            int course = Convert.ToInt32(Console.ReadLine());

        }

        static void CW1()
        {
            Student st1 = new Student("JANIS", "BERZINS", 3);

            Student st2 = new Student("MADARA", "PRIEDE", 3);

            st1.Print();
            st2.Print();
        }

        static void CW2()
        {
            Shape sh1 = new Shape(23, 33, 33);
            Shape sh2 = new Shape(23, 44, 33, 33);
            sh1.Print();
            sh2.Perimeter();
        }
    }
}
