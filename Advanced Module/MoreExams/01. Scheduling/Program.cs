using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _01.TheFightOfGondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int currentPlate = 0;
            int currentWarrior = 0;

            for (int i = 1; i <= numberOfWaves; i++)
            {
                Stack<int> currentWarriors = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

                if (i % 3 == 0)
                {
                    int additionalPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(additionalPlate);
                }


                currentPlate = plates.Peek();

                while (plates.Any() && i <= numberOfWaves)
                {


                    if (plates.Peek() >= currentWarriors.Peek())
                    {
                        currentPlate -= currentWarriors.Pop();


                        if (currentPlate == 0)
                        {
                            plates.Dequeue();
                            break;
                        }

                    }
                    else
                    {
                        currentWarrior = currentWarriors.Pop();
                        currentWarriors.Push(currentWarrior-plates.Dequeue());
                        continue;
                        //currentPlate=plates.Dequeue();

                    }




                }



                if (plates.Any() && i + 1 > numberOfWaves)
                {
                    Console.WriteLine($"The people successfully repulsed the orc's attack.");
                    Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
                    break;
                }

                if (!plates.Any() /*&& i < numberOfWaves && i + 1 != 2*/)
                {
                    Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                    Console.WriteLine($"Orcs left: {string.Join(", ", currentWarriors)}");
                    break;
                }
            }
        }
    }
}
