using System;
using System.Security.Cryptography.X509Certificates;

namespace MD_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Commands:\n start - start new operation;\n +, -, *, / - math operations;\n end -  to  exit calculator;");
            InputCommand();

        }

        static void InputCommand()
        {
            string input = Console.ReadLine().ToLower();
            switch(input)
            {
                case "start":
                    Numbers.num1 = InputNumber();
                    break;

                case "+":
                    Numbers.num2 = InputNumber();
                    Numbers.result = Sum(Numbers.num1, Numbers.num2);
                    Console.WriteLine(Numbers.result);
                    break;
                case "-":
                    Numbers.num2 = InputNumber();
                    Numbers.result = Dif(Numbers.num1, Numbers.num2);
                    Console.WriteLine(Numbers.result);
                    break;
                case "*":
                    Numbers.num2 = InputNumber();
                    Numbers.result = Mult(Numbers.num1, Numbers.num2);
                    Console.WriteLine(Numbers.result);
                    break;
                case "/":
                    Numbers.num2 = InputNumber();
                    Numbers.result = Div(Numbers.num1, Numbers.num2);
                    Console.WriteLine(Numbers.result);
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unknown command, please, start over...");
                    break;

            }
            InputCommand();
        }
        static int InputNumber()
        {
            Console.WriteLine("Input number:");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        static int Sum(int a, int b)
        {
          return a + b;
        }
        static int Dif(int a, int b)
        {
            return a - b;
        }
        static int Div(int a, int b)
        {
            return a/b;
        }
        static int Mult(int a, int b)
        {
            return a*b;
        }
    }
}
