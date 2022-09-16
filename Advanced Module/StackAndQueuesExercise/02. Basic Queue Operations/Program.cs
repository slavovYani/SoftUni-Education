using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            int numbersToEnqueue = firstInput[0];
            int numbersToDequeue = firstInput[1];
            int desiredNumber = firstInput[2];

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                numbers.Enqueue(secondInput[i]);
            }

            for (int i = 0; i < numbersToDequeue; i++)
            {
                if (numbers.Count > 0)
                {
                    numbers.Dequeue();
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);


            }
            else
            {
                if (numbers.Contains(desiredNumber))
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
}
