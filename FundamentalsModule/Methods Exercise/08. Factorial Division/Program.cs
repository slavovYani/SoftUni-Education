using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());

           double result = CalculateFactorials(firstNumber, secondNumber);
            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateFactorials(double firstN, double secondN)
        {
            double firstResult = 1;
            double secondResult = 1;

            for (double i = firstN; i > 0; i--)
            {
                firstResult *= i;
            }

            for (double i = secondN; i > 0; i--)
            {
                secondResult *= i;
            }

            return (firstResult / secondResult);
        }
    }
}
