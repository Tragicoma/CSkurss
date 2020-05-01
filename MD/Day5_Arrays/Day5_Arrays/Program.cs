using System;

namespace Day5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayInput();
            //Average();
            FindThePosition();
        }


        static void FindThePosition()
        {
            int[] randoms = new int[10];
            for(int i=0; i<randoms.Length; i++)
            {
                Random random = new Random();
                randoms[i] = random.Next(1, 11);
            }
            Console.WriteLine("Which number are you looking for?");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Positions in array:");

            for (int i =0; i<randoms.Length; i++)
            {
                if (randoms[i] == position)
                    Console.Write(i);
            }
            
        }
        static void Average()
        {
            int sum = 0;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            int average = sum / array.Length;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);

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
