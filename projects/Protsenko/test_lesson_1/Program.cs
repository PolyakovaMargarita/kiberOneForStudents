using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApplication1
{
    class Human
    {
        public string name;
        public int age;
        public int height;
    }
    class Child : Human
    {
        new public int name = 5;
        new public int age = 100;

        public void SetAge(int x)
        {
            if((x > 0) & (x < 16))
            {
                age = x;
            }
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child Ivan = new Child();
            Ivan.Print();

            Ivan.SetAge(3);
            Ivan.Print();

          Console.ReadLine();
            }
        }
    }