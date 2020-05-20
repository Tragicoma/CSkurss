using System;

namespace Day10_Algorythm
{
    class Program
    {


        static void Main(string[] args)
        {
            //BubbleSort();
            //InsertionSort();
            TimeMeasure();
        }
        static void TimeMeasure()
        {

            var time1 = DateTime.Now;
            BubbleSort();
            var time2 = DateTime.Now;
            var diff1 = (time2 - time1).TotalSeconds;
            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(diff1);


        }

        static void InsertionSort()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 41);
            }
            Print(array);


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
            Print(array);
        }
        static void BubbleSort()
        {
            Random random = new Random();
            int[] array = new int[55000];
            int cup;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 41);
            }
            
            Console.WriteLine();

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

        static void Array()
        {

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
