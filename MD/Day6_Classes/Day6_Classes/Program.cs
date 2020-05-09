using System;

namespace Day6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTask1();
            //ClassTask2();
            HW1();
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
            Console.WriteLine("Enter student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student's surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter student's course(1-3): ");
            int course = Convert.ToInt32(Console.ReadLine());


            Student st1 = new Student(name, surname, course);

            Student st2 = new Student("MADARA", "PRIEDE", 3);

            st1.Print();
            st2.Print();
            
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
    }
}
