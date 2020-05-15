using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Day9_ListsOfObjects
{
    class Task
    {
        List<Car> CarList = new List<Car>();
        public void CarHomework()

        {
            
            string input = "";
            while (input != "0")
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - print car list");
                Console.WriteLine("2 - add a new car to the list");
                Console.WriteLine("3 - find a car");
                Console.WriteLine("0 - exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PrintCars();
                        break;
                    case "2":
                        AddCar();
                        break;
                    case "3":
                        FindCar();
                        break;
                    case "0":
                        break;
                    default:
                        break;

                }
            }
        }

        public void FindCar()
        {
            Console.WriteLine("SEARCH BY:");
            Console.WriteLine("1 - Color, 2 - Brand, 3 - Amount of doors, 4 - Back");
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("What color are you looking for?");
                    string keyC = Console.ReadLine().ToLower();
                    for(int i=0; i<CarList.Count; i++)
                    {
                        if(CarList[i].GetColor().ToLower().Contains(keyC)) // Contains, what if color is "baby pink" or "ruby red"
                        { CarList[i].Print(); }
                    }
                    break;
                case "2":
                    Console.WriteLine("What brand are you looking for?");
                    string keyB = Console.ReadLine().ToLower();
                    for (int i = 0; i < CarList.Count; i++)
                    {
                        if (CarList[i].GetBrand().ToLower() == keyB)
                        { CarList[i].Print(); }
                    }

                    break;
                case "3":
                    Console.WriteLine("How many doors are you looking for?");
                    int keyD = Convert.ToInt32(Console.ReadLine().ToLower());
                    try { }
                    catch { Console.WriteLine("Um, not sure what you mean by that..."); }
                    for (int i = 0; i < CarList.Count; i++)
                    {
                        if (CarList[i].GetDoors() == keyD)
                        { CarList[i].Print(); }
                    }
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Wrong input, try again...");
                    break;

            }
        }
        public void AddCar()
        {
            if(CarList.Count<5)
            {
                Console.WriteLine("YOUR CAR DESCRIPTION:");
                Console.Write("COLOR:"); string c = Console.ReadLine().ToLower();
                Console.Write("BRAND:"); string b = Console.ReadLine().ToLower();
                Console.Write("DOORS:"); int d = Convert.ToInt32(Console.ReadLine());
                CarList.Add(new Car(c, b, d));
            }
            else
            {
                Console.WriteLine("There are alreay 5 cars in the list, that's enough.");
            }
            
        }
        public void PrintCars()
        {
            foreach(Car car in CarList)
            {
                car.Print();
            }

        }
        
        List<Student> list = new List<Student>();
        public void Task1()
        {
            
            string input = "";
            while(input!="0")
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - print student list");
                Console.WriteLine("2 - add a new student to the list");
                Console.WriteLine("0 - exit");
                input = Console.ReadLine();
                

                switch (input)
                {
                    case "1":
                        PrintList();
                        break;
                    case "2":
                        AddStudent();
                        break;
                    case "0":
                        break;
                    default:
                        break;

                }
            }

        }

        public void AddStudent()
        {
            Console.WriteLine("Please, write name, surname and course: ");
            list.Add(new Student(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
        }
        public void PrintList()
        {
            foreach(Student st in list)
            {
                st.print();
            }
        }
    }
}
