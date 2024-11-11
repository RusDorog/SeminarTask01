using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25->да
//a = 2 b = 10->нет
//a = 9; b = -3->нет
//a = -3 b = 9->да


namespace PracticeTask03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            String A = Console.ReadLine();
            Console.WriteLine("Введите число B");
            String B = Console.ReadLine();

            int num1 = Int32.Parse(A);
            int num2 = Int32.Parse(B);

            if (num1 == num2 / num1 )
            {
                Console.WriteLine($"{num1} является квадратом {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} не является квадратом {num2}");
            }
        }
    }
}
