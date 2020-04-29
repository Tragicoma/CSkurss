using System;

namespace Day4_MoreLōōps
{
    class Program
    {
        static void Main(string[] args)
        {
            GuesssTheNumber();
        }

        static void GuesssTheNumber()
        {
            Console.WriteLine("Try to guess the right number (from 1 to 10)");
            Random random = new Random();
            int secret = random.Next(1,10);

            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine("Make a guess :)");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == secret)
                {
                    Console.WriteLine("WoW, you guessed it! You win!");
                    TryAgain();
                }
                else
                {
                    Console.WriteLine("Hm, not quite...");
                }
                
            }

            Console.WriteLine("You lost!");
            TryAgain();   

        }

        static void TryAgain()
        {
            Console.WriteLine("Would you like to try again? (Y/N)");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")
            {
                GuesssTheNumber();
            }
            else if (answer == "n")
            {
                Environment.Exit(0);
            }
        }
    }
}
