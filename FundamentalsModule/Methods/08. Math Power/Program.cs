using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(_Math_Power(@base, power));
        }

        static double _Math_Power(double @base, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }
            return result;
        }
    }
}
