using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
                //            Add 3
                //Remove 2
                //RemoveAt 1
                //Insert

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(command[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int numbersToRemoveAt = int.Parse(command[1]);
                        numbers.RemoveAt(numbersToRemoveAt);
                        break;
                    case "Insert":
                        int numbersToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        numbers.Insert(indexToInsert, numbersToInsert);
                        break;
                    case "end":

                        Console.WriteLine(String.Join(" ",numbers));
                        return;
                    
                }
                

            }
        }
    }
}
