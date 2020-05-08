using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Day6_Classes
{
    public class Task
    {
        private static int a = 0;
        private static int b = 0;




public static void stars(int a)
        { 
        for(int i = 0; i<a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
       
    }
}
