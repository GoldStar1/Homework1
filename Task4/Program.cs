using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Задание 4
                Программа считывает размер массива А
                Программа считывает массив А

                Отсортировать массив по убыванию и вывести в консоль */

            Console.Write("Please input array_A size:  ");
            int size;
            size = int.Parse(Console.ReadLine());

            int[] array_A = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element " + i + ":  ");
                array_A[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array A: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < size; i++)
            {
                Console.Write(array_A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            int temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if(array_A[j] > array_A[i])
                    {
                        temp = array_A[i];
                        array_A[i] = array_A[j];
                        array_A[j] = temp;
                    }
                }
            }

            Console.Write("Sorted array A: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < size; i++)
            {
                Console.Write(array_A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
