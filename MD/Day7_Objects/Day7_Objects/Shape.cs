using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Day7_Objects
{
    class Shape
    {
        private int sideA = 0;
        private int sideB = 0;
        private int sideC = 0;
        private int sideD = 0;
        private int sideE = 0;

        public Shape(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

        }

        public Shape(int sideA, int sideB, int sideC, int sideD)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }

        public Shape(int sideA, int sideB, int sideC, int sideD, int sideE)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
            this.sideE = sideE;
        }

        public void Print()
        {
            Console.WriteLine("a: " + this.sideA);
            Console.WriteLine("b: " + this.sideB);
            Console.WriteLine("c: " + this.sideC);
            if (this.sideD!=0)
            Console.WriteLine("d: " + this.sideD);
            if (this.sideE != 0)
            Console.WriteLine("e: " + this.sideE);


        }

        public void Perimeter()
        {
            Console.WriteLine(sideA+sideB+sideC+sideD+sideE);
        }


    }
}
