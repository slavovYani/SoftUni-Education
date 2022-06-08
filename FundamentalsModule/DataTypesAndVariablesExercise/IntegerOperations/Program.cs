using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int result = (firstNumber + secondNumber) / divider * multiplier;

            Console.WriteLine(result);
        }
    }
}

