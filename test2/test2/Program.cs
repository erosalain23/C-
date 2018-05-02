using System;
using System.Collections.Generic;
using System.IO;
namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C#\test2\test.txt";
            List<string> names = new List<string>();
            names.Add("Alain");
            names.Add("Leriche");
            names.Add("Guyssel");
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write("Name1 : ");
                sw.WriteLine(names[0]);
                sw.Write("Name2 : ");
                sw.WriteLine(names[1]);
                sw.Write("Name3 : ");
                sw.WriteLine(names[2]);
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                string[] temp = line.Split(':');
                Console.WriteLine(temp[2]);
            }
            Console.ReadLine();
        }
    }
}
