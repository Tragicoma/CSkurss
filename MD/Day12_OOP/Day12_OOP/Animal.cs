using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_OOP
{
    abstract class Animal
    {
        protected bool HasWings;
        protected int LegCount;
        protected string MoveSound;

        public void Sleep()
        {
            Console.WriteLine("The " + this.GetType().Name + " is sleeping... shh");
        }


        public void Move()
        {
            Console.WriteLine("The " + this.GetType().Name + " is moving!  " + this.MoveSound);
        }
        public abstract void MakeSound();
        public virtual void Print()
        {
            Console.WriteLine("Does it have wings? - " + HasWings);
            Console.WriteLine("How many  legs does it have? - " + LegCount);
        }
        
    }
}
