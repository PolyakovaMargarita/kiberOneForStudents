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
            int discr;
            Console.WriteLine("Entew a numbew and pwess Entew ")
            string str = Console.ReadLine();
            discr = Convert.ToInt32(str);
            if (discr < 0)
            {
            Console.WriteLine("Nyow!")
            }
            else if (discr == 0) 
            {
            Console.WriteLine("Wan numbew!")
            }
            else if (discr > 0)
            {
            Console.WriteLine("Manyeow")
            }
            Console.ReadKey();

        }
    }
}