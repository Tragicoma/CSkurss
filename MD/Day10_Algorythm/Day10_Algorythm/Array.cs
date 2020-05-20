using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Algorythm
{
    class Array
    {
        public int[] array = new int[20000];

       

        public void FillArray()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 41);
            }
        }
    }
}
