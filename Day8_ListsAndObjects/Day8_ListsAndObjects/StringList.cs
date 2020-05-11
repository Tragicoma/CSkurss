using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Day8_ListsAndObjects
{
    class StringList
    {
        private List<String> listOfValues; 

        public StringList()
        {
            listOfValues = new List<String>();
            
        }

        public void Task1()
        {
            string choice = "";
            while(choice!="0")
            { 
              Console.WriteLine("MENU \n1 - Print current list; \n2 - Add a string to  the list; \n" +
              "3 - Remove by Index; \n4 - Find string; \n0 - Exit; ");
              choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Print();
                        break;

                    case "2":
                        Add();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Find();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;

                }
                   
            }

            //un dodam cilvekam iespeju izveleties
            //1. Izvadit
            //2. Pievienot
            //3. Dzest
            //0. Iziet
        }

        private void Print()
        {
            foreach (string s in listOfValues)
                Console.WriteLine(s);

            Console.WriteLine();
        }

        private void Add()
        {
            Console.WriteLine("Type your string: ");
            string input = Console.ReadLine();
            listOfValues.Add(input);
        }

        private void Delete()
        {
            Console.WriteLine("Type index of the string you wish to delete:");
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                Convert.ToInt32(index);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            listOfValues.RemoveAt(index);
        }

        private void Find()
        {
            Console.WriteLine("What are you looking for?");
            string input = Console.ReadLine();
            Console.WriteLine("We found: ");
            int finds = 0;
            for (int i = 0; i < listOfValues.Count; i++)
            {
                if (listOfValues[i].Contains(input))
                {
                    Console.WriteLine(i + "( " + listOfValues[i] + " )");
                    finds++;
                }
            }
            if (finds == 0)
            {
                Console.Write("Nothing :(");
                Console.WriteLine();
            }

        }
    }
}
