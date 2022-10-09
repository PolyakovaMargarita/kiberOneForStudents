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
            // Целое число дискриминант
            int diskr;

            //Приглашение пользователя ввести число
            Console.WriteLine("Enter a number and press Enter: ");

            //Получение первой строки
            string str = Console.ReadLine();

            //Преобразование первой строки в число
            diskr = Convert.ToInt32(str);

            //Дискриминант меньше нуля
            if (diskr < 0)
            {
                //Выведем сообщение
                Console.WriteLine("Нет решения");
            }
            if (diskr == 0)
            {   
                //Выведем сообщение
                Console.WriteLine("Есть одно решение");
            }
            if (diskr > 0)
            {
                //Выведем сообщение
                Console.WriteLine("Есть два решение");
            }

            Console.ReadKey();
        }
    }
}