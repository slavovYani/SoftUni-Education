using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(VowelsCounter(input));
        }

        private static int VowelsCounter(string input)
        {
            char[] theWord = input.ToCharArray();
            string AllVowels = "aoeiu";
            char[] Vowels = AllVowels.ToCharArray();
            int count = 0;

            for (int i = 0; i < theWord.Length; i++)
            {
                for (int j = 0; j < Vowels.Length; j++)
                {
                    if (theWord[i]==Vowels[j])
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }

    }
}
