using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            input = input.Reverse().ToArray();
            
            Stack<string> currentStack = new Stack<string>(input);
            
            ;
            int result = 0;

            while(currentStack.Count > 1)
            {
                int currentNum = int.Parse(currentStack.Pop());
                char @operator = char.Parse(currentStack.Pop());
                int nextNum = int.Parse(currentStack.Pop());
                if (@operator=='+')
                {
                    
                    result = currentNum+nextNum;
                }
                else
                {
                    result = currentNum-nextNum;
                }

                currentStack.Push(result.ToString());
            }

            Console.WriteLine(currentStack.Peek());
        }
    }
}
