using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

namespace SeminarTask03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void EventNumber()
            {
                Console.Write("Введите число: ");
                String main_number = Console.ReadLine();

                int user_number = Convert.ToInt32(main_number);

                if (user_number % 2 == 0)
                {
                    Console.WriteLine($"Число {user_number} четное");
                }
                else
                {
                    Console.WriteLine($"Число {user_number} не четное");
                }
            }
            EventNumber();
        }
    }
}
