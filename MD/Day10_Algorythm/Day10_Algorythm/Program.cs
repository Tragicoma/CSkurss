using System;

namespace Day10_Algorythm
{
    class Program
    {


        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 41);
            }
            
            int[] array2 = new int[100000];
            for (int i =0;i<array2.Length;i++)
            {
                array2[i] = array[i];
            }
            

            var time1 = DateTime.Now;
            BubbleSort(array);
            
            var time2 = DateTime.Now;
            var diff1 = (time2 - time1).TotalSeconds;
            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(diff1);
            
            var time3 = DateTime.Now;
            InsertionSort(array2);
            var time4 = DateTime.Now;
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine((time4-time3).TotalSeconds); 
            //Insertion method ends up being 5x faster
        }
       

        static void InsertionSort(int[] array)
        {
            
            int j, inserted;
            
            for(int i = 1; i<array.Length; i++ )
            {
                inserted = array[i];
                j = i - 1;

                while (j>=0 && array[j]>inserted)
                {
                    array[j + 1] = array[j];
                    j = j - 1;

                }
                array[j + 1] = inserted;
            }

        }
        static void BubbleSort(int[] array)
        {

            int cup;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        cup = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = cup;
                    }
                }
            }

            
        }

      
        static void Print(int[] a)
        {
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
