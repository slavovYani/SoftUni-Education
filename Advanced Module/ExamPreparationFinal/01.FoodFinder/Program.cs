using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.FoodFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ").Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ").Select(char.Parse));

            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";

            Dictionary<string,int> findedWords = new Dictionary<string,int>();


            while (consonants.Any())
            {
                char currVow = vowels.Dequeue();
                vowels.Enqueue(currVow);
                char curCons = consonants.Pop();


                if (pear.Any())
                {

                    pear = ManipulateWord(currVow, curCons, pear);

                    if (!pear.Any())
                    {
                        findedWords.Add("pear",1);
                    }
                }

               

                if (flour.Any())
                {

                    flour = ManipulateWord(currVow, curCons, flour);

                    if (!flour.Any())
                    {
                        findedWords.Add("flour",2);
                    }
                }

                if (pork.Any())
                {

                    pork = ManipulateWord(currVow, curCons, pork);

                    if (!pork.Any())
                    {
                        findedWords.Add("pork",3);
                    }
                }

                if (olive.Any())
                {

                    olive = ManipulateWord(currVow, curCons, olive);

                    if (!olive.Any())
                    {
                        findedWords.Add("olive",4);
                    }
                }


            }

            Console.WriteLine($"Words found: {findedWords.Count}");

            foreach (var item in findedWords.OrderBy(x=>x.Value))
            {
                Console.WriteLine(item.Key);
            }
        }

        private static string ManipulateWord(char currVow, char curCons, string word)
        {
            if (word.Contains(curCons))
            {
                word = word.Remove(word.IndexOf(curCons), 1);

            }
            if (word.Contains(currVow))
            {
                word = word.Remove(word.IndexOf(currVow), 1);
            }
            return word;

        }
    }
}
