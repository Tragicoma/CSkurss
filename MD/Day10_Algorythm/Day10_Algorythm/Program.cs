using System;

namespace Day10_Algorythm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            int cup;
            for(int i=0; i<10; i++)
            {
                array[i] = random.Next(1, 41);
            }
            Print(array);
            Console.WriteLine();

            for (int i = 0; i<=array.Length-2; i++)
            {
                for(int j = 0; j<=array.Length-2; j++)
                {
                    if(array[j]>array[j+1])
                    {
                        cup = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = cup;
                    }
                }
            }

            
            Print(array);
        }
        static void Print(int[] a)
        {
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
        }
    }
}
