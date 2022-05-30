using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            for (int i = 0; i < n; i++)
            {
                 number1 += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                 number2 += int.Parse(Console.ReadLine());
            }

            if (number1 == number2)
            {
                Console.WriteLine($"Yes, sum = {number1}");
            }
            else 
            {
                Console.WriteLine($"No, diff = {Math.Abs(number1 - number2)}");
            }


        }
    }
}
