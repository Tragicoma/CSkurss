using System;

namespace Day6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \n Please, insert the amount of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Task.stars(rows);

        }
    }
}
