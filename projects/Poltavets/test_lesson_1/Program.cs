using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           string poisk = "a";

            Console.WriteLine("Enter a string");

            string str = Console.ReadLine();
            int dlina = str.Length;

            for (int i = 0; i < dlina; i++)
            {
                if (str[i].ToString() == poisk)
                {
                    Console.WriteLine(poisk + "on = " + i + " position" );
             
                }
            }
             Console.ReadKey();
        }
    }
}