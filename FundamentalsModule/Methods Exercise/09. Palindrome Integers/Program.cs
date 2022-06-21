using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            
            while (input!="END")
            {
            Console.WriteLine(_Palindrome_Integers(input).ToString().ToLower()); 
                input = Console.ReadLine();
                
            }

        }

        private static bool _Palindrome_Integers(string input)
        {
            string reversedInput = String.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                reversedInput+=input[i];
            }

            return reversedInput == input;
        }
    }
}
