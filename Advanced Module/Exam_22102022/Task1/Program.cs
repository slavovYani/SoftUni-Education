using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> miligramsOfCoffein = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int coffeinStamat = 0;

            while (miligramsOfCoffein.Any() && energyDrinks.Any())
            {

                if (miligramsOfCoffein.Peek() * energyDrinks.Peek() + coffeinStamat <= 300)
                {

                    coffeinStamat += miligramsOfCoffein.Pop() * energyDrinks.Dequeue();

                }
                else
                {
                    miligramsOfCoffein.Pop();
                    energyDrinks.Enqueue(energyDrinks.Dequeue()); // for checking here

                    if (coffeinStamat - 30 >= 0)
                    {
                        coffeinStamat -= 30; // check Stamat here bellow 0

                    }
                    else
                    {
                        coffeinStamat = 0;
                    }

                }

            }

            if (energyDrinks.Any())
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {coffeinStamat} mg caffeine."); /// not sure here







        }
    }
}
