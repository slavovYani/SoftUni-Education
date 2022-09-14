using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split().ToArray();
            int gameNum = int.Parse(Console.ReadLine());

            Queue<string> names = new Queue<string>(players);
            int tosses = 1;
            while (names.Count > 1)
            {

                string currentPlayer = names.Dequeue();

                if (tosses == gameNum)
                {
                    Console.WriteLine($"Removed {currentPlayer}");
                    tosses = 1;
                    continue;
                }

                tosses++;

                names.Enqueue(currentPlayer);


            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
