using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedWord = string.Empty;

            while (word!="end")
            {
                

                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                Console.WriteLine(word + " = " + reversedWord);
                word = Console.ReadLine();
                reversedWord = string.Empty;    
            }
        }
    }
}
