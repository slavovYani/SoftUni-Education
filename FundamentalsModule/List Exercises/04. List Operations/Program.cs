using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // • Add { number} – add the given number to the end of the list
            //• Insert { number} { index} – insert the number at the given index
            //• Remove { index} – remove the number at the given index
            //• Shift left { count} – first number becomes last. This has to be repeated the specified number of times
            //• Shift right { count} – last number becomes first. To be repeated the specified number of times


            while (true)
            {
               string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        break;

                    case "Insert":

                        int numberToInsert = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index > numbers.Count - 1|| index<0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(index, numberToInsert);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        if (indexToRemove > numbers.Count - 1|| indexToRemove<0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Shift":
                       numbers= Shift(command, numbers);
                        break;
                    case "End":
                        Console.WriteLine(string.Join(" ",numbers));
                        return;
                        
                }


            }

        }

        private static List<int> Shift(string[] command, List<int> numbers)
        {
            int count = int.Parse(command[2]);

            if (command[1] == "left")
            {
                for (int i = 0; i < count; i++)
                {

                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }

            return numbers;
        }
    }
}
