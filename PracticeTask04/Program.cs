using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Пользователь вводит два числа, программа должна проверить является ли первое число произведением двух других чисел.
//Например:
//25 -> 25, 5, 5;
//28 -. 28, 7, 4;

namespace PracticeTask04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            String A = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            String B = Console.ReadLine();
            Console.WriteLine("Введите третье число: ");
            String C = Console.ReadLine();

            int number1 = Convert.ToInt32(A);
            int number2 = Convert.ToInt32(B);
            int number3 = Convert.ToInt32(C);

            if (number1 == number2 * number3 || number2 == number3 * number1 || number3 == number1 * number2)
            {
                Console.WriteLine("Является произведением ");
            }
            else
            {
                Console.WriteLine("Не является произведением ");
            }
        }
    }
}
