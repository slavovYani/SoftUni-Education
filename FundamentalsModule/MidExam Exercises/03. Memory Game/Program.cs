using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenseOfElements = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] twoIndexesOrCommand = Console.ReadLine().Split().ToArray();

                if (twoIndexesOrCommand[0]=="end")
                {
                    Console.WriteLine(string.Join(" ",sequenseOfElements));
                    return;
                }
                int firstIndex = int.Parse(twoIndexesOrCommand[0]);
                int secondIndex = int.Parse(twoIndexesOrCommand[1]);
                bool equalIndexes = sequenseOfElements[firstIndex] == sequenseOfElements[secondIndex];
                if (equalIndexes)
                {
                    int biggerIndex = Math.Max(firstIndex, secondIndex);
                    int smallerIndex = Math.Min(firstIndex, secondIndex);
                    
                    sequenseOfElements.Remove(sequenseOfElements[biggerIndex]);
                    sequenseOfElements.Remove(sequenseOfElements[smallerIndex]);

                    Console.WriteLine($"Congrats! You have found matching elements - ${sequenseOfElements[biggerIndex]}!");
                }

            }


        }
    }
}
