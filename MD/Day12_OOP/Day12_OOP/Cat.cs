using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_OOP
{
    class Cat : Animal
    {

        public Cat()
        {
            HasWings = false;
            LegCount = 4;
            MoveSound = "Hop!";
        }
        
        public void DropVase()
        {
            Console.WriteLine("The cat slowly pushes the vase off your table... Just great!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow...");
        }
    }
}
