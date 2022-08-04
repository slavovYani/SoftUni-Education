using System;
using System.Text.RegularExpressions;

namespace _01.Match_full_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z]\w+\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Value+ " ");
            }
        }
    }
}
