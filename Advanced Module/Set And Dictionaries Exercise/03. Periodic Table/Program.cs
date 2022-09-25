using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueChemElements = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] currElemArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currElemArray.Length; j++)
                {
                    uniqueChemElements.Add(currElemArray[j]);

                }
            }
            uniqueChemElements= uniqueChemElements.OrderBy(x=>x).ToHashSet();

            foreach (var item in uniqueChemElements)
            {
                Console.Write(item+" ");
            }
        }
    }
}
