using System;
using System.Threading;
using System.Linq;


namespace Day1_MD
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            

            //1. un 2. uzdevumi

            Console.WriteLine("Press ENTER to start a conversation with GARRY");
            Console.ReadLine();
            Console.WriteLine("Hello there! :)  I'm Garry, what is your name?");
            string PlayerName = Console.ReadLine();
            Console.WriteLine(PlayerName + ", that's a cool name! Nice to meet you!");
            Thread.Sleep(2000);
            Console.WriteLine("Tell me something, " + PlayerName + "...");
            Thread.Sleep(2000);
            Console.WriteLine("I hope this is not too personal, but...");
            Thread.Sleep(3000);
            Console.WriteLine("What is your favourite Ice cream flavour?");
            string IceCream = Console.ReadLine();
            Console.WriteLine("Okay, sounds yum. What about your hobbies? Name your favourite activity:");
            string Hobby = Console.ReadLine();
            Console.WriteLine("Ok,ok... So, if you could do that anywhere in the world... where would it be? Name a country:");
            string Place = Console.ReadLine();
            Console.WriteLine("oooh... Can you imagine eating " + IceCream + " Ice cream after " + Hobby + " somewhere in " + Place + "?");
            Console.Write("Sounds amazing... Thank You for sharing :)");
            Pause();

            //3.uzdevums

            Console.WriteLine("GARRY'S PERFORMANCE WILL NOW BE EVALUATED...");
            Console.WriteLine("ON A SCALE OF 1 TO 100, " +
                    "HOW DO YOU RATE GARRY'S ABILITY TO PROVIDE A WELCOMING ATMOSPHERE?");

            int a = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ON THE SAME 1 TO 100 SCALE, HOW DO YOU RATE GARRY'S APPEARANCE?");
            int b = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FROM 1 TO 100, HOW SATISFIED ARE YOU WITH THE OVERALL USER EXPERIENCE?");
            int c = System.Convert.ToInt32(Console.ReadLine());
            
            
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("YOU RATED GARRY'S WARM WELCOME THE HIGHEST: RATING OF "+ a);
                }
                else
                {
                    Console.WriteLine("YOU RATED YOUR OVERALL EXPERIENCE THE HIGHEST: RATING OF " + c);
                }
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine("YOU RATED GARRY'S APPEARANCE THE HIGHEST: RATING OF " + b);
                }
                else
                {
                    Console.WriteLine("YOU RATED YOUR OVERALL EXPERIENCE THE HIGHEST: RATING OF " + c);
                }
            }



            /*
            int[] ratings = {a, b, c};
            int max = ratings.Max();

            Console.WriteLine(max);
            */



            if (a==b || a==c || b==c)
            {
                Console.WriteLine("(THERE WAS MORE THAN ONE RATING WITH THE SAME VALUE!)");
            }
           


            //3.uzdevums(extra)

            Pause();

            if (a + b + c >= 200)
            {
                Console.WriteLine("THE FINAL EVALUATION MET THE CRITERIA. GARRY WILL RECEIVE A RAISE.");
                Console.WriteLine("Gary: Yay!!! :)");
            }
            else
            {
                Console.WriteLine("THE FINAL EVALUATION DID NOT MEET THE CRITERIA. GARRY WILL BE TERMINATED.");
                Console.WriteLine("Gary: Oh, no!  ;(");
            }
            Pause();

            //4.uzdevums
            
                a = 3;
                b = 9;

                b = b / a;
                a = b * b;

              


            //Pauzes starp uzdevumiem utt.
            void Pause()
            {
                Console.Write("    Press ENTER to continue..." + "");
                Console.ReadLine();
            }

        }

    }


}
