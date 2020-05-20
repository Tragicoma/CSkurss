using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_OOP
{
    class Dog : Animal
    {
        
        public Dog()
        {
            HasWings = false;
            LegCount = 4;
            MoveSound = "Hadush!";
        }

        public void FetchStick()
        {
            Console.WriteLine("Aww, the dog brought back the stick :) Good boy!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof,Woof!");
        }
        



    }
}
