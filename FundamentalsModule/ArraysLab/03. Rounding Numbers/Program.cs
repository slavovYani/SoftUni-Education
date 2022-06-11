using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] values = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double[] number = new double[values.Length];
            

            for (int i = 0; i < values.Length; i++)
            {

                number[i] = double.Parse(values[i]);
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]} => {(int)Math.Round(number[i],MidpointRounding.AwayFromZero)}");
                Console.WriteLine();
            }


        }
    }
}
