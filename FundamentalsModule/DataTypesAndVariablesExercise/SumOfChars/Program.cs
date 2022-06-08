using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
            char letter = char.Parse(Console.ReadLine());
                sum += (int)(letter);

            }
            Console.WriteLine($"The sum equals: {sum}");


            
        }
    }
}
