using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, List<string>>();

            string[] firstInputSepareted = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var wordWithExpl in firstInputSepareted)
            {
                var wordWithExplArr = wordWithExpl.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                var wordKey = wordWithExplArr[0];
                var wordExplanation = wordWithExplArr[1];

                if (!myDictionary.ContainsKey(wordKey))
                {
                    myDictionary.Add(wordKey, new List<string>());
                    myDictionary[wordKey].Add(wordExplanation);

                }
                else
                {
                    myDictionary[wordKey].Add(wordExplanation);
                }

            }

            var onlyWords = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var finalCommand = Console.ReadLine();




            if (finalCommand=="Test")
            {
                foreach (var word in onlyWords)
                {
                    if (myDictionary.ContainsKey(word))
                    {

                        Console.WriteLine($"{word}:");

                        foreach (var explanation in myDictionary[word])
                        {
                            Console.WriteLine($" -{explanation}");

                        }

                    }

                }

            }
            else if (finalCommand=="Hand Over")
            {

                foreach (var word in myDictionary.Keys)
                {
                    Console.Write($"{word} ");
                }
                
            }



        }
    }
}
