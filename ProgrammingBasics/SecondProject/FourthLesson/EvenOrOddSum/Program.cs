using System;

namespace EvenOrOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;
                }

                else if (i % 2 != 0)
                {
                    sumOdd += number;
                }
                    
            }
               if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumEven}");

            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");

            }
        }
    }
}
