using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

namespace SeminarTask04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            String numberN = Console.ReadLine();

            int numN = Convert.ToInt32(numberN);

            int even_number = 1;
            while (even_number <= numN)
            {
                if (even_number % 2 == 0)
                Console.Write(even_number + ", ");
                even_number++;
            }
        }
    }
}
