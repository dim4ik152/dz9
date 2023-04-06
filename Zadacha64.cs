using System;

namespace RecursiveCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());

            PrintNumbersRecursively(n);
        }

        static void PrintNumbersRecursively(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                PrintNumbersRecursively(n - 1);
            }
        }
    }
}