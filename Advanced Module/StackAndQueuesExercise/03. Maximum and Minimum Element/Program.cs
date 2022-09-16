using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            Stack<sbyte> numbers = new Stack<sbyte>(sbyte.MaxValue);

            for (int i = 0; i < numberOfLines; i++)
            {
                byte[] input = Console.ReadLine().Split().Select(byte.Parse).ToArray();

                sbyte command = (sbyte)input[0];

                switch (command)
                {
                    case 1:
                        sbyte currentNumberToPush = (sbyte)input[1];
                        numbers.Push(currentNumberToPush);
                        break;
                    case 2:
                        if (!numbers.Any())
                        {
                            continue;
                        }
                        numbers.Pop();
                        break;
                    case 3:
                        if (!numbers.Any())
                        {
                            continue;
                        }
                        Console.WriteLine(numbers.Max());
                        break;
                    case 4:
                        if (!numbers.Any())
                        {
                            continue;
                        }
                        Console.WriteLine(numbers.Min());
                        break;
                    
                }
            }

            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
