using System;

namespace Day3_GiveLōōps
{
    class Program
    {
        static void Main(string[] args)
        {
            //BiggestNumber();
            //HowMany();
            //Stars();
            BiggestSmallest();
        }


        static void BiggestSmallest()
        {
            Console.WriteLine("Please, input first integer:");
            string input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);            
            int biggest = skaitlis;
            int smallest = skaitlis;
            Console.WriteLine("Type 'stop' to end input and get final  results.");
            while (input != "stop")
            {
                Console.WriteLine("Please, input another integer:");
                input = Console.ReadLine();
                if(input == "stop")
                {
                    continue;
                }

                skaitlis = Convert.ToInt32(input);
                biggest = Math.Max(biggest,skaitlis);
                smallest = Math.Min(smallest, skaitlis);             

            }

            Console.WriteLine("Biggest: " + biggest);
            Console.WriteLine("Smallest: " + smallest);

        }
        static void Stars()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i=4; i>0; i--)
            {
                for (int j=i; j>0; j--) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*
             string stars = "*";
            
             for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(stars);
                stars = stars + "*";
            }

             for(int i = 0; i < 4; i++)
             {
                 Console.WriteLine(stars);
                 stars = stars.Remove(stars.Length-1);
             }
            */


        }

        static void BiggestNumber()
        {
            int lielaakais = 0;

            for(int i = 1; i<6; i++)
            {
                Console.WriteLine("Please, input #" +i+" integer");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if(skaitlis>lielaakais)
                { lielaakais = skaitlis; }

            }

            Console.WriteLine("The biggest number is " + lielaakais);


        }

        static void HowMany()
        {
            int pozitiivie = 0;
            int negatiivie = 0;
            int nulles = 0;
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine("Please, input #" + i + " integer");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if(skaitlis>0)
                { pozitiivie++; }
                else if(skaitlis<0)
                { negatiivie++; }
                else
                { nulles++; }
                                  
            }
            Console.WriteLine("Out of the given numbers:");
            Console.WriteLine("There were " + pozitiivie + " positive numbers, "  + negatiivie + " negative  and " + nulles + " zero values");



        }
    }
}
