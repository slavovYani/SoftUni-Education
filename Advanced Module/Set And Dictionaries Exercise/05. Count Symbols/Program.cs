using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputInArr = input.ToCharArray();

            

            SortedDictionary<char, int> alphabeticalOrder = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!alphabeticalOrder.ContainsKey(inputInArr[i]))
                {
                    alphabeticalOrder.Add(inputInArr[i], 0);
                }
                alphabeticalOrder[input[i]]++;

            }

            foreach (var character in alphabeticalOrder)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
