using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Например:
//4-> 16
//- 3-> 9
//- 7-> 49

namespace PracticeTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Ноль и в Африке ноль");
            }
            else
            {
                number = number * number;
                Console.WriteLine($"Квадрат введенного число равен {number}");
            }
            Console.ReadLine();

        }
    }
}
