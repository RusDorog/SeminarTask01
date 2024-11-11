using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
namespace PracticeTask06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            String digit_number = Console.ReadLine();

            int three_number = Convert.ToInt32(digit_number);
            //three_number = three_number % 10;  //Последняя цифра числа
            three_number = (three_number / 10) % 10; //Вторая цифра числа

            Console.WriteLine($"Последняя цифра числа {digit_number} - {three_number}");
        }
    }
}
