using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_for_30_04_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Задание 1
                Пользователь вводит 2 числа.
                Программа сохраняет два числа в две переменных.
                Первая переменная - А, вторая переменная - B.
                Необходимо вывести оба числа, в обратной последовательности. Например:
                l A = 123, B = 4246
                l На выходе будет:
                321 6424  */

            Console.Write("Plese input number \"a\":  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int a;
            a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Plese input number \"b\":  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int b;
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("New numbers are: ");
            Console.Write("A:   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                Console.Write(a % 10);
                a = a / 10;
            } while (a!=0);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("B:   ");
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.Write(b % 10);
                b = b / 10;
            } while (b != 0);


            Console.ReadKey();
        }
    }
}
