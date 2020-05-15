using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_ListsOfObjects
{
    class Car
    {
        public Car(string color, string brand, int doors)
        {
            this.Color = color;
            this.Brand = brand;
            this.Doors = doors;
        }
        private string Color;
        private string Brand;
        private int Doors;

        public string GetColor()
        { return this.Color; }

        public string GetBrand()
        { return this.Brand; }

        public int GetDoors()
        { return this.Doors; }


        public void Print()
        {
            Console.WriteLine("------------------");
            Console.WriteLine(Color); ;
            Console.WriteLine(Brand);
            Console.WriteLine(Doors);
            Console.WriteLine("------------------");
        }
    }
}
