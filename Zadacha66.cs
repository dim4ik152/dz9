using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());

            int sum = CalculateSum(m, n);
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
        }

        static int CalculateSum(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}