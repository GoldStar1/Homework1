using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задание 2
                Программа считывает размер массива А
                Программа считывает массив А

                Перевернуть массив (отзеркалить массив) и вывести его в консоль

                Например:
                Вход: 1,2,3,10,8,30,5
                Вывод: 5,30,8,10,3,2,1 */

            Console.Write("Please input array size:  ");
            int size;
            size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element " + i + ":  ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Original array is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.Write("New array is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = size-1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
