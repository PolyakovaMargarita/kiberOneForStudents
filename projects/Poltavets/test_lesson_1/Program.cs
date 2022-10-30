using System;
using System.Collections.Generic;
using System.Linq;
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
        new public int age = 5;
        new public int height = 100;

        public void SetAge(int x)
        {
            if ((x > 0) & (x < 16))
            age = x;
        }
          public void Print()
      {
        Console.WriteLine("name: " + name);
        Console.WriteLine("age: " + age);
        Console.WriteLine("height: " + height);
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

            Ivan.SetAge(48);
            Ivan.Print();

            Console.ReadLine();
        }
    }   
}       