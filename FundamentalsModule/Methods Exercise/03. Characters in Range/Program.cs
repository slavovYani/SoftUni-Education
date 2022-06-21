using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char biggestChar;
            char smallerChar;

            if (firstChar>secondChar)
            {
                biggestChar = firstChar;
                smallerChar = secondChar;
            }
            else
            {
                biggestChar = secondChar;
                smallerChar = firstChar;
            }

            PrintBetweenChars(smallerChar, biggestChar);
            
        }

        private static void PrintBetweenChars(int small, int big)
        {
            for (int i = small+1; i < big; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
