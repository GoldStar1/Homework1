using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Задание 3
                Программа считывает размер массива А
                Программа считывает массив А
                Программа считывает размер массива B
                Программа считывает массив B

                Необходимо просуммировать i-тый элемент массива А с i-тым элементом массива B.
                Если i-того элемента нет - считать его нулем. Сохранить результат в массив C
    
                Вывести массив - результат всех сумм. */

            // розбираємось з першим масивом
            Console.Write("Please input array_A size:  ");
            int size_A;
            size_A = int.Parse(Console.ReadLine());

            int[] array_A = new int[size_A];

            for (int i = 0; i < size_A; i++)
            {
                Console.Write("Element " + i + ":  ");
                array_A[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array A: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < size_A; i++)
            {
                Console.Write(array_A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            // розбираємось з другим масивом
            Console.Write("Please input array_B size:  ");
            int size_B;
            size_B = int.Parse(Console.ReadLine());

            int[] array_B = new int[size_B];

            for (int i = 0; i < size_B; i++)
            {
                Console.Write("Element " + i + ":  ");
                array_B[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array B: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < size_B; i++)
            {
                Console.Write(array_B[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            // робота з третім масивом
            int size_C;
            if (size_A > size_B) size_C = size_A;
            else size_C = size_B;

            int[] array_C = new int[size_C];

            // варіант 1, якщо масив А більший за масив Б
            if (size_A > size_B)
            {
                int check = -1;
                for (int i = 0; i < size_B; i++)
                {
                    array_C[i] = array_A[i] + array_B[i];
                    check++;
                }

                for (int i = check + 1; i < size_A; i++)
                {
                    array_C[i] = array_A[i];
                }

                Console.Write("New array is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < size_C; i++)
                {
                    Console.Write(array_C[i] + " ");
                }
            } 
            // варіант 2, якщо масив Б більший за масив А
           else      
           if (size_B > size_A)
            {
                int check1 = -1;
                    for (int i = 0; i < size_A; i++)
                    {
                        array_C[i] = array_A[i] + array_B[i];
                        check1++;
                    }
                for (int i = check1 + 1; i < size_B; i++)
                {
                    array_C[i] = array_B[i];
                }

                Console.Write("New array is: ");
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < size_C; i++)
                {
                    Console.Write(array_C[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
