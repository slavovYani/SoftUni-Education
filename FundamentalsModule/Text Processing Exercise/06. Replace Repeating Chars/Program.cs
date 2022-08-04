using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < input.Length-1; i++)
            {
                char currentChar = input[i];
                char nextChar = input[i + 1];

                if (currentChar==nextChar)
                {
                    input.Remove(i, 1);
                    i = -1;
                }
            }
            Console.WriteLine(input);
        }
    }
}
