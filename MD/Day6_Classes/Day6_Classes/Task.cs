﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Day6_Classes
{
    public class Task
    {
        private static int a = 0;
        private static int b = 0;



        public static void SetA(int inp)
        {
            a = inp;
        }

        public static void SetB(int inp)
        {
            b = inp;
        }
        public static int GetA()
        {
            return a;
        }
        public static int GetB()
        {
            return b;
        }

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
