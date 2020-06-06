using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_JSON
{
    class Car
    {
        public string Brand;
        public string Color;
        public int DoorCount;

        public Car(string brand, string color, int doorC)
        {
            this.Brand = brand;
            this.Color = color;
            this.DoorCount = doorC;
        }
    }
}
