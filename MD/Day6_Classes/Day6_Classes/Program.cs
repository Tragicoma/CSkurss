using System;

namespace Day6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTask1();
            ClassTask2();
            //HW1();
        }

        static void ClassTask1()
        {
            Console.WriteLine("Hello!\n Please, insert the amount of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Task.stars(rows);
        }

        static void ClassTask2()
        {
            Console.WriteLine("Hello!\n Please, insert two numbers:");
            int inputA = Convert.ToInt32(Console.ReadLine());
            int inputB = Convert.ToInt32(Console.ReadLine());
            Task.SetA(inputA);
            Task.SetB(inputB);
            Console.WriteLine(Task.GetA()+Task.GetB());

        }

       public static void HW1()
        {
            StudentForm();
            Console.WriteLine("Thank You!\nPress 'P' to print out your student info. ");
            string input = Console.ReadLine().ToUpper();
            if (input == "P")
                Student.Print();
            
        }
        public static void StudentForm()
        {
            Console.WriteLine("Enter student's name: ");
            Student.SetName(Console.ReadLine());
            Console.WriteLine("Enter student's surname: ");
            Student.SetSurname(Console.ReadLine());
            Console.WriteLine("Enter student's course(1-3): ");
            Student.SetCourse(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
