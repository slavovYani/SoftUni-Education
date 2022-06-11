using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] number = new int[input.Length];
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(input[i]);

                if (number[i] % 2 == 0)
                {
                    sumEven += number[i];
                }
                else
                {
                    sumOdd += number[i];
                }
            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
