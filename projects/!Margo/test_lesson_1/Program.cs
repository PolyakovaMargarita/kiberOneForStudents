using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Programeee
    {
        public int Add (int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int r1 = p.Add(54, 78);
            Console.WriteLine("54 + 78 = " + r1);

            int r2 = p.Add(5, 8);
            Console.WriteLine("5 + 8 = " + r2);

            Console.ReadLine();
        }
    }
}