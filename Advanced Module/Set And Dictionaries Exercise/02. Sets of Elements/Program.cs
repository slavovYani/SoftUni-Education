using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] botshLines = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int firstLine = botshLines[0];
            int secondLine = botshLines[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();



            for (int i = 0; i < firstLine; i++)
            {
                int currNumToAdd = int.Parse(Console.ReadLine());
                firstSet.Add(currNumToAdd);


            }

            for (int i = 0; i < secondLine; i++)
            {
                int currNumToRemove = int.Parse(Console.ReadLine());

                
                    secondSet.Add(currNumToRemove);
                

            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(String.Join(" ",firstSet));




        }
    }
}
