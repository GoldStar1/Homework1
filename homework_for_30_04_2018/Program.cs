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
            
            Console.Write("Plese input number \"a\":  ");
            int a;
            a = int.Parse(Console.ReadLine());

            Console.Write("Plese input number \"b\":  ");
            int b;
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("New numbers are: ");
            Console.Write("A:   ");
            do
            {
                Console.Write(a % 10);
                a = a / 10;
            } while (a!=0);
            Console.WriteLine();

            Console.Write("B:   ");
            do
            {
                Console.Write(b % 10);
                b = b / 10;
            } while (b != 0);


            Console.ReadKey();
        }
    }
}
