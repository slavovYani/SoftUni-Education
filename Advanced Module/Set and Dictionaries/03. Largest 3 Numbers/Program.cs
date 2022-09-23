using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            var sortedNumbers = numbers.OrderByDescending(x=>x).Take(3).ToHashSet();

            Console.WriteLine(String.Join(" ",sortedNumbers));
        }
    }
}
