using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var encryptedMessage = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int positionOfChar = 0;
                char currentChar = input[i];
                positionOfChar = currentChar;
                positionOfChar += 3;
                char newChar = Convert.ToChar(positionOfChar);

                encryptedMessage.Append(newChar);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}
