using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Day18_REST
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://my-json-server.typicode.com/Tragicoma/StudentServer2/db";

            WebClient client = new WebClient();
            String response = client.DownloadString(url);

            DataStatus ds = JsonConvert.DeserializeObject<DataStatus>(response);
            if(ds.Status == "success")
            {
                foreach(Student s in ds.Data)
                {
                    Console.WriteLine(s);
                }
            }


        }

        static void CreateList()
        {
            List<Student> students = new List<Student>();
            Random random = new Random();
            for (int i = 1; i < 10; i++)
            {
                students.Add(new Student($"Janis{i}", "Berzins", random.Next(1, 4)));
            }

            String json = JsonConvert.SerializeObject(new DataStatus("success", students), Formatting.Indented);
            File.WriteAllText(@"D:\Jauna mape\C#_Maaciibas\Rest\db.json", json);
        }
    }
}
