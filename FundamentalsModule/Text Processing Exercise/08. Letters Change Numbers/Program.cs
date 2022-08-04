using System;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


            decimal result = 0;
            decimal totalResult = 0;

            for (int i = 0; i < input.Length; i++)
            {

                var currentString = new StringBuilder(input[i]);
                string fullString = currentString.ToString();
                int firstLetterPosition = Convert.ToInt32(char.ToLower(currentString[0]) - 96);
                int lastLetterPosition = Convert.ToInt32(char.ToLower(currentString[currentString.Length - 1]) - 96);
                currentString.Remove(0, 1);
                currentString.Remove(currentString.Length - 1, 1);
                decimal currentNumber = decimal.Parse(currentString.ToString());

                if (char.IsUpper(fullString[0]))
                {
                    result = currentNumber / firstLetterPosition;
                }
                else if (char.IsLower(fullString[0]))
                {
                    result = currentNumber * firstLetterPosition;
                }

                if (char.IsUpper(fullString[fullString.Length - 1]))
                {
                    result -= lastLetterPosition;
                }
                else if (char.IsLower(fullString[fullString.Length - 1]))
                {
                    result += lastLetterPosition;
                }

                totalResult += result;

            }
            Console.WriteLine($"{totalResult:f2}");
            
        }
    }
}
