using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<int, string> kitchen = new Dictionary<int, string>();
            Dictionary<string, int> kitchenCounter = new Dictionary<string, int>()
            {
                {"Sink",0 },
                {"Oven",0 },
                {"Countertop",0 },
                {"Wall",0 },
                {"Floor",0 },


            };



            kitchen.Add(40, "Sink");
            kitchen.Add(50, "Oven");
            kitchen.Add(60, "Countertop");
            kitchen.Add(70, "Wall");
            kitchen.Add(0, "Floor");





            while (whiteTiles.Any() && greyTiles.Any())
            {

                if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    int currentTileSum = whiteTiles.Pop() + greyTiles.Dequeue();

                    if (kitchen.ContainsKey(currentTileSum))
                    {

                        string currPlace = kitchen[currentTileSum];

                        kitchenCounter[currPlace]++;


                    }
                    else
                    {
                        kitchenCounter["Floor"]++;
                    }


                }
                else
                {
                    int currWhiteTile = whiteTiles.Pop() / 2;
                    whiteTiles.Push(currWhiteTile);

                    int currGreyTile = greyTiles.Dequeue();
                    greyTiles.Enqueue(currGreyTile);
                }

            }

            if (whiteTiles.Any())
            {

                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            else
            {

                Console.WriteLine($"White tiles left: none");
            }

            if (greyTiles.Any())
            {

                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            else
            {

                Console.WriteLine($"Grey tiles left: none");
            }




            kitchenCounter = kitchenCounter.OrderByDescending(v => v.Value).ThenBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in kitchenCounter)
            {
                if (item.Value != 0)
                {

                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

        }
    }
}
