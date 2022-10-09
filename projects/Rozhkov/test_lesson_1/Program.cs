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
            double x = 11;
            stirng str = "string x = ";
            Console.WriteLine(str + x);

            x = x / 3 + 10;
            str =    "variable " + str;
            Console.WriteLine(str + x);
            Console.WriteLine(str[0]);
            Console.WriteLine(str.lenght);


            Console.Read();
        }
    }
}