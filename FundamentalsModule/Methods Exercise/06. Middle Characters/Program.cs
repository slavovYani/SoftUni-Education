using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            bool stringIsEven = IsEven(inputText);
            if (stringIsEven)
            {
            FindMeMiddleLettersEven(inputText);

            }
            else
            {
            FindMiddleLetterOdd(inputText);

            }


        }

        private static void FindMeMiddleLettersEven(string input)
        {
            Console.Write(input[input.Length / 2-1]);
            Console.Write(input[input.Length / 2]);


        }

        private static void FindMiddleLetterOdd(string input)
        {
            Console.WriteLine(input[input.Length / 2]); 
        }

        private static bool IsEven(string input) => input.Length % 2 == 0;
        
    }
}
