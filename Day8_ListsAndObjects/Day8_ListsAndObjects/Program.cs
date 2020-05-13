using System;
using System.Collections.Generic;
using System.Linq;


namespace Day8_ListsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Ints n1 = new Ints();
            Ints n2 = new Ints();
            n1.AddFive();
            n2 = n1;
            n1.Reverse();
            
        }

       

    }
}
