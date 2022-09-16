using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();

            int numbersToPush = ints[0];
            int numbersToPop = ints[1];
            int desiredElement = ints[2];

            for (int i = 0; i < numbersToPush; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            

            for (int i = 0; i < numbersToPop; i++)
            {
                if (numbers.Count>0)
                {
                    numbers.Pop();
                }

            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (numbers.Contains(desiredElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
