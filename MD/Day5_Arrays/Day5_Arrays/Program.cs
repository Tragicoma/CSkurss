using System;

namespace Day5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayInput();
        }

        static void ArrayInput()
        {
            int[] a = new int[5];
            int sum = 0;

            for (int i = 0; i<=4; i++)
            {
                Console.WriteLine("Please input your number:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            for(int i = 0; i<=4; i++)
            {
                sum = sum + a[i];
            }
            Console.Write("The sum of your numbers is: " + sum);

        }
    }
}
