using System;

namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(n));
        }
        public static int CalculateFactorial(int n)
        {
            int sum = 0;

            if (n == 0)
            {
                return 1;
            }

            sum = n * CalculateFactorial(n - 1);
            return sum;
        }
    }
}
