using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3

namespace SeminarTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            String numA = Console.ReadLine();
            Console.Write("Введите число B: ");
            String numB = Console.ReadLine();

            int A = Int32.Parse(numA);
            int B = Int32.Parse(numB);

            int max = A;

            if (A > max) max = A;
            if (B > max) max = B;

            Console.Write("max = ");
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
