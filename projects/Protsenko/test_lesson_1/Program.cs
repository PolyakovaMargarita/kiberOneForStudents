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
        int diskr;
            Console.WriteLine("Enter a number and press Enter ");

            string str = Console.ReadLine();

            diskr = Convert.ToInt32(str);

            if (diskr < 0)  { 
                Console.WriteLine("нет решения");
            }
             if (diskr == 0)  { 
                Console.WriteLine("Есть одно решение");
             }
              if (diskr > 0)  { 
                Console.WriteLine("есть два решения");
             }  
              Console.ReadKey();
           }
        }
    }