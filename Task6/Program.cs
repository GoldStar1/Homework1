using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Задание 6 (дополнительное)
                Пользователь вводит 2 числа. Ширину и высоту. Необходимо создать массив массивов типа инт.
                И заполнить его числами от 1000 и выше. При этом крайние элементы полученной матрицы чисел должны быть числами -100.
                Выведите результат на экран.  */

            Console.Write("Plese input length:  ");
            Console.ForegroundColor = ConsoleColor.Green;
            int length;
            length = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Plese input height:  ");
            Console.ForegroundColor = ConsoleColor.Green;
            int height;
            height = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            Random rand = new Random();

            for (int i = 0; i < height; i++)
            {
                int[] array = new int[length];
                if ((i == 0) || (i == height - 1))
                {
                    for (int j = 0; j < length; j++)
                    {
                        array[j] = -100;
                        Console.Write(array[j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < length; j++)
                    {
                        if ((j == 0) || (j == length - 1))
                        {
                            array[j] = -100;
                            Console.Write(array[j] + " ");
                        }
                        else
                        {
                            array[j] = rand.Next(1000, 2147483647);
                            Console.Write(array[j] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
