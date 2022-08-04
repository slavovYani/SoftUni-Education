using System;
using System.Text;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstNum = input[0];
            string secondNum = input[1];

            Console.WriteLine(MultiplyChars(firstNum,secondNum));
            

            
        }
        public static int MultiplyChars(string str1,string str2)
        {
            int result = 0;
            string bigger = string.Empty;
            string smaller = string.Empty;

            if (str1.Length>str2.Length)
            {
                bigger= str1;
                smaller= str2;
            }
            else
            {
                bigger = str2;
                smaller= str1;
            }

            for (int i = 0; i < smaller.Length; i++)
            {
                result += smaller[i] * bigger[i];
            }

            for (int i = smaller.Length; i < bigger.Length; i++)
            {
                result += bigger[i];
            }


            return result;
        }
    }
}
