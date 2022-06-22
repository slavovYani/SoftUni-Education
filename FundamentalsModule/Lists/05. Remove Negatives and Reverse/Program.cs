using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numberOfCycles = numbers.Count;

            for (int i = 0; i <= numbers.Count-1; i++)
            {
                if (numbers[i]<0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }

                if (numbers.Count==0)
                {
                    Console.WriteLine("empty");
                }

            }
            numbers.Reverse();
            Console.Write(string.Join(" ",numbers));
        }
    }
}
