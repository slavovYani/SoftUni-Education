using System;
using System.Collections.Generic;

namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);

            }
            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}
