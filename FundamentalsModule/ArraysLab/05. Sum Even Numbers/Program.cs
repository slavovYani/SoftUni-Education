using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] number = new int[input.Length];
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(input[i]);

                if (number[i] % 2 == 0)
                {
                    sum += number[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
}
