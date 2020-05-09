using System;
using System.Collections.Generic;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomi = new List<int>();
            Random random = new Random();
            for(int i = 0; i<11; i++)
            {
                randomi.Add(random.Next(1, 101));
            }
            Console.WriteLine("MENU:\nType LIST to print out the random numbers;" +
                "\nType REMOVE to remove a number by it's index;\nType EXIT to leave;");
            while (true)
            {
                string input = Console.ReadLine().ToUpper();
                if (input == "LIST")
                {
                    foreach (int num in randomi)
                        Console.WriteLine(num);
                }
                else if (input == "REMOVE")
                {
                    Console.WriteLine("Index of the number you would like to remove:");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index <= randomi.Count && index >= 0)
                        randomi.RemoveAt(index);
                    else
                        Console.WriteLine("Wrong input!");
                }
                else if (input == "EXIT")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Something's not right, try again..");

                }
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

        static void CW3()
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
    }
}
