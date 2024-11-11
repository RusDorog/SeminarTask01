using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дается произвольное число, надо вывести вторую цифру числа, или сообщить такой цифры нет.
//Например:
//12345  -> 2;
//357898 -> 5;
//24     ->4

namespace PracticeTask07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число: ");
            String digit_number = Console.ReadLine();
            int length = digit_number.Length;
            int three_number = Convert.ToInt32(digit_number);

            
            //three_number = three_number % 10;  //Последняя цифра числа
            //three_number = (three_number / 10) % 10; //Вторая цифра числа
            int i = 0;
             while (i < (length - 2))
            {
                three_number = three_number / 10;
                i++;
            }


            Console.WriteLine($"Вторая цифра числа {digit_number} - {three_number % 10}");
        }
    }
}
