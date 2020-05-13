using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Day8_ListsAndObjects
{
    class Ints
    {
        private List<int> numbers;

        public Ints()
        {
            numbers = new List<int>();
        }

        public void AddFive()
        {
            Console.WriteLine("Type your numbers: ");
            int input;

            while (numbers.Count < 5)
            {
                input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }
            Console.WriteLine("-------------");
            Print();
            Console.WriteLine("-------------");
            
        }
        public void Reverse()
        {
            numbers.Reverse();
            Print();
        }

        public bool IsSame(List<int> a, List<int> b )
        {
             return a.SequenceEqual(b);
        }
        public void Print()
        {
            foreach (int n in numbers)
                Console.Write(n);
            Console.WriteLine();
        }

     

    }
}
