using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"
namespace PracticeTask05_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите целое число ");
            //int i = 5;
            //while (i <= 15)
            //{
            //    Console.Write(i + ", ");
            //    i++;
            //}
            Console.WriteLine("Введите число: ");
            String enter_number = Console.ReadLine();

            int number = Int32.Parse(enter_number);
            int i = -number;

            while (i <= number)
            {
                Console.WriteLine(i + ",");
                i++;
            }
        }
    }
}
