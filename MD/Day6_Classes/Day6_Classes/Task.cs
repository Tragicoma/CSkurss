﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Day6_Classes
{
    public class Task
    {
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
