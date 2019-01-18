using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Задание 5 (дополнительное)
                Пользователь вводит 2 числа. Ширину и высоту. Необходимо в консоли отрисовать прямоугольник из символов ‘+’. 

                Пример:
                Ввод: 2 3
                Вывод: 
                + +
                + +
                + +  */
           
            Console.Write("Please input width:  ");
            int width;
            width = int.Parse(Console.ReadLine());

            Console.Write("Please input height:  ");
            int height;
            height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Here we go!");

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0;  j < width;  j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
