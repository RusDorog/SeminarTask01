using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

namespace PracticeTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 7");
            String day_week = Console.ReadLine();

            int week = Int32.Parse(day_week);

            if (week == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (week == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (week == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (week == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (week == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (week == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (week == 7)
            {
                Console.WriteLine("Воскресение");
            }
            else if (week < 1 || week > 7)
            {
                Console.WriteLine("Пожалуйста введите число от 1 до 7");
            }
            Console.ReadLine();
        }
    }
}
