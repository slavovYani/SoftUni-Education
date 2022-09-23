using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> numberOccur = new Dictionary<double, int>();

            foreach (var number in input)
            {
                if (!numberOccur.ContainsKey(number))
                {
                    numberOccur[number] = 0;
                }
                numberOccur[number]++;

            }

            foreach (var item in numberOccur)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
