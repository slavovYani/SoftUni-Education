using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?<day>[0-9]{2})([\-\./])(?<month>[A-Z]\w+)\1(?<year>[0-9]{4})\b";

            MatchCollection validDates = Regex.Matches(input, pattern);

            foreach (Match date in validDates)
            {
                var day = date.Groups["day"];
                var month = date.Groups["month"];
                var year = date.Groups["year"];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
