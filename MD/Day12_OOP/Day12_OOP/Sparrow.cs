using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_OOP
{
    class Sparrow : Animal
    {
        private bool IsAfraid = true;
        public Sparrow()
        {
            HasWings = true;
            LegCount = 2;
            IsAfraid = true;
            MoveSound = "Tr-tr-tr-tr!";
        }
        public override void MakeSound()
        {
            Console.WriteLine("Chirp, chirp!");
        }
        public new void Print()
        {
            Console.WriteLine("Does it have wings? - " + HasWings);
            Console.WriteLine("How many  legs does it have? - " + LegCount);
            Console.WriteLine("Is it scared? - " + IsAfraid);
        }
    }
}
