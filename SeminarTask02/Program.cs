using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

namespace SeminarTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            String numA = Console.ReadLine();
            Console.Write("Введите число B: ");
            String numB = Console.ReadLine();
            Console.Write("Введите число C: ");
            String numC = Console.ReadLine();

            int A = Int32.Parse(numA);
            int B = Int32.Parse(numB);
            int C = Int32.Parse(numC);

            int max = A;
            if (max == A) max = A;
            if (B > max) max = B;
            if (C > max) max = C;

            Console.WriteLine("max = ");
            Console.WriteLine(max);

        }
    }
}
