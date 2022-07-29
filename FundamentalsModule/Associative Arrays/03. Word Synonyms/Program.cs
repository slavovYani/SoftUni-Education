using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCounts = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string,List<string>>();

            for (int i = 0; i < numberOfCounts; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                    
                }
                synonyms[word].Add(synonim);
                    
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
