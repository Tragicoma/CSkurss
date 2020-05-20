using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_OOP
{
    class Parrot : Animal
    {
        public Parrot()
        {
            HasWings = true;
            LegCount = 2;
            MoveSound = "Swoosh!";
        }

        public void StealShiny()
        {
            Console.WriteLine("No,no...The parrot took my earring! GIVE IT BACK!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Rhaa, Polly wants a cracker!");
        }
    }
}
