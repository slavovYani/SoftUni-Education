using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Second
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listWithCoffies = Console.ReadLine().Split().ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0]=="Include")
                {
                    listWithCoffies.Add(command[1]);
                }
                else if (command[0]=="Remove")
                {
                    int numberOfCoffiesToRemove = int.Parse(command[2]);
                    listWithCoffies= RemovingCoffes(listWithCoffies, command[1], numberOfCoffiesToRemove);
                }
                else if (command[0]=="Prefer")
                {
                    int indexCoffie1 = int.Parse(command[1]);
                    int indexCoffie2 = int.Parse(command[2]);
                    listWithCoffies= ReplacingCoffies(listWithCoffies, indexCoffie1, indexCoffie2);
                }
                else if(command[0]=="Reverse")
                {
                    listWithCoffies.Reverse();
                }


            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ",listWithCoffies));
        }

        private static List<string> ReplacingCoffies(List<string> listWithCoffies, int indexCoffie1, int indexCoffie2)
        {
            if (indexCoffie1<=listWithCoffies.Count-1 & indexCoffie2<=listWithCoffies.Count-1)
            {
                int smallerIndex = Math.Min(indexCoffie1, indexCoffie2);
                int biggerIndex = Math.Max(indexCoffie1, indexCoffie2);
                string firstCoffie = listWithCoffies[smallerIndex];
                string secondCoffie = listWithCoffies[biggerIndex];

                listWithCoffies.Insert(smallerIndex,secondCoffie);
                listWithCoffies.RemoveAt(biggerIndex + 1);

                listWithCoffies.Insert(biggerIndex+1, firstCoffie);
                listWithCoffies.RemoveAt(smallerIndex + 1);

            }

            return listWithCoffies;
        }

        private static List<string> RemovingCoffes(List<string> listWithCoffies, string firstOrLast, int coffiesToRemove)
        {
            if (coffiesToRemove<listWithCoffies.Count)
            {
                if (firstOrLast == "first")
                {
                    for (int i = 1; i <= coffiesToRemove; i++)
                    {
                        listWithCoffies.RemoveAt(0);
                    }
                }
                else if (firstOrLast == "last")
                {
                    for (int i = 1; i <= coffiesToRemove; i++)
                    {
                        listWithCoffies.RemoveAt(listWithCoffies.Count - 1);
                    }

                }

            }
            return listWithCoffies;
            
            
        }
    }
}
