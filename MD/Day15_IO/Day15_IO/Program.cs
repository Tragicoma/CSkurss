using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Day15_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input!="0")
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("Create new file - 1");
                Console.WriteLine("Read file - 2");
                Console.WriteLine("Edit file - 3");
                Console.WriteLine("Exit - 0");
                input = Console.ReadLine();
                
                if (input=="1")
                {
                    
                    Console.WriteLine("Start writing your file... \nIf you are done - type 'DONE'");
                    List<string> list = new List<string>();
                    while(true)
                    {
                        string s = Console.ReadLine();
                        if (s.ToUpper() == "DONE")
                        { break; }
                        else
                        { list.Add(s); }
                    }
                    Console.WriteLine("Overwite existing file - 1");
                    Console.WriteLine("Save as new file - 2");
                    string save = Console.ReadLine();
                    while(true)
                    {
                        if (save == "1")
                        {
                            return;
                        }
                        else if (save == "2")
                        {
                            Console.WriteLine("Name your file:");
                            string n = Console.ReadLine();
                            SaveNew(n, list);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Come again?");
                            return;
                        }
                    }
                }

                else if(input=="2")
                {
                    try
                    {
                        Console.WriteLine("What is your file called?");
                        string name = Console.ReadLine();
                        Open(name);
                    }
                    catch
                    { Console.WriteLine("Can't open this file :(");}
          
                }
                else if(input == "3")
                {

                    Console.WriteLine("Enter file name:");
                    string name = Console.ReadLine();
                    Edit(name);
                }

                else if(input == "0")
                {
                    Console.WriteLine("Bye, bye! :)");
                }
                else
                {
                    Console.WriteLine("Not sure what you mean with that...");
                }

            }

            static void SaveNew(string name, List<string> list)
            {
                StreamWriter sw = new StreamWriter(@"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name);
                foreach (string s in list)
                {
                    sw.WriteLine(s);
                }

                sw.Close();
            }

            static void Open(string name)
            {
                StreamReader sr = new StreamReader(@"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name);
                string line = sr.ReadLine();
                Console.WriteLine("-------------------");
                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }
                Console.WriteLine("-------------------");

                sr.Close();
            }

            static void Edit(string name)
            {
                Open(name);

                string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name;
                List<string> vaardi = File.ReadAllLines(fp).ToList();
                Console.WriteLine("Which line would you like to  edit?");
                int line = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type new input:");
                vaardi[line] = Console.ReadLine();
                StreamWriter sw = new StreamWriter(@"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name);
                foreach (string s in vaardi)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                Open(name);


            }
            
        }

    }
}
