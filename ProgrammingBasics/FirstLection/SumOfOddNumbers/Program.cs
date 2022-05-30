using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var sum = 0;
            var number = 1;
            for (int i = 1; i <= count; i++)
            {
                sum += number;
                Console.WriteLine(number);
                number += 2;

            }
                Console.WriteLine($"Sum: {sum}");
        }
    }
}
