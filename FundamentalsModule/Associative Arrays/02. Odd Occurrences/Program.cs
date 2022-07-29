using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> sortedWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                
                if (!sortedWords.ContainsKey(word))
                {
                    sortedWords.Add(word, 0);
                }
                sortedWords[word]++;
            }

            sortedWords = sortedWords.Where(word => word.Value % 2 != 0).ToDictionary(word => word.Key, word => word.Value);

            Console.WriteLine(string.Join(" ",sortedWords.Keys)); 
        }
    }
}
