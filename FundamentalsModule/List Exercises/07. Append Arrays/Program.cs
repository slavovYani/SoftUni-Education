using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayInput = Console.ReadLine().Split('|').Reverse().ToArray();

            string temporary = string.Join(" ", arrayInput);

            string[] finalResult = temporary.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
