using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < Math.Min(firstPlayerDeck.Count, secondPlayerDeck.Count); i++)
            {
                if (firstPlayerDeck[i] > secondPlayerDeck[i])
                {
                    firstPlayerDeck.Add(secondPlayerDeck[i]);
                    firstPlayerDeck.Add(firstPlayerDeck[i]);
                    firstPlayerDeck.RemoveAt(i);
                    secondPlayerDeck.RemoveAt(i);
                    i--;
                }
                else if (firstPlayerDeck[i] < secondPlayerDeck[i])
                {
                    secondPlayerDeck.Add(firstPlayerDeck[i]);
                    secondPlayerDeck.Add(secondPlayerDeck[i]);
                    secondPlayerDeck.RemoveAt(i);
                    firstPlayerDeck.RemoveAt(i);
                    i--;
                }
                else
                {
                    firstPlayerDeck.RemoveAt(i);
                    secondPlayerDeck.RemoveAt(i);
                    i--;
                }
            }
            if (firstPlayerDeck.Count > secondPlayerDeck.Count)
            {
                int sumOfFirst = firstPlayerDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {sumOfFirst}");
            }
            else
            {
                int sumOfSecond = secondPlayerDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {sumOfSecond}");
            }
        }
    }
}
