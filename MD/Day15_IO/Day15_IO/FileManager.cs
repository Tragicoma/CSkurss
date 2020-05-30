using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;

namespace Day15_IO
{
    class FileManager
    {
       public static void Read(string name)
        {
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name;
            StreamReader sr = new StreamReader(fp);
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
        public static void WriteTo(string name)
        {
            string fp = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name;
            Console.WriteLine("Type stuff: ");
            string content = Console.ReadLine();
            File.WriteAllText(fp, content);

            Read(name);
        }

        public static void SwapAndNew(string name1)
        {
            string fp1 = @"D:\Jauna mape\C#_Maaciibas\C--kurss\MD\Day15_IO\" + name1;
            List<string> list1 = File.ReadAllLines(fp1).ToList();
            list1.Reverse();
            
            File.WriteAllLines(fp1 + "new", list1);

                                    
        }
    }
}
