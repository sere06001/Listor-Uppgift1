using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Skriv in ett eller flera namn, skriv en tom rad när du vill sluta.");
            string svar = Console.ReadLine();
            while (svar != "")
            {
                list.Add(svar);
                svar = Console.ReadLine();
            }
            list.Sort();
            list.Reverse();
            foreach (string namn in list)
            {
                Console.WriteLine(namn);
            }
            Console.ReadKey();
        }
    }
}