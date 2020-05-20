using System;

namespace Day12_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparrow s = new Sparrow();
            Parrot p = new Parrot();
            Cat c = new Cat();
            Dog d = new Dog();

            c.Move();
            d.Move();
            s.Move();
            p.Move();
            Console.WriteLine("--------");
            Console.WriteLine("THE CAT:");
            Console.WriteLine("--------");
            c.Sleep(); c.MakeSound(); c.DropVase(); c.Print();
            Console.WriteLine("--------");
            Console.WriteLine("THE DOG:");
            Console.WriteLine("--------");
            d.Sleep(); d.MakeSound(); d.FetchStick(); d.Print();
            Console.WriteLine("--------");
            Console.WriteLine("THE PARROT:");
            Console.WriteLine("--------");
            p.Sleep(); p.MakeSound(); p.StealShiny(); p.Print();
            Console.WriteLine("--------");
            Console.WriteLine("THE SPARROW:");
            Console.WriteLine("--------");
            s.Sleep(); s.MakeSound(); s.Print();



        }
    }
}
