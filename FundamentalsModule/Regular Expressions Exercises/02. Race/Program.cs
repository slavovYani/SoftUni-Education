using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfPersons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var personsCompete = new Dictionary<string, int>();
            
            var input = Console.ReadLine();
            string patternForNames = @"(?<name>[A-Za-z]+)";
            string patternForDistance = @"(?<distance>\d*)";

            while (input!="end of race")
            {
                var currentName = Regex.Matches(input, patternForNames);
                var currentDistance = Regex.Matches(input, patternForDistance,RegexOptions.IgnorePatternWhitespace);
                int distancePerPerson = 0;
                string name = String.Join("", currentName);

                string number = string.Join("", currentDistance);

                foreach (char num in number)
                {
                    distancePerPerson += int.Parse(num.ToString());
                }

                if (!personsCompete.ContainsKey(name) && listOfPersons.Contains(name))
                {
                personsCompete.Add(name, distancePerPerson);

                }
                else if(personsCompete.ContainsKey(name) && listOfPersons.Contains(name))
                {
                    personsCompete[name] += distancePerPerson;
                }

                input = Console.ReadLine();
            }

            var persons = personsCompete.OrderByDescending(x => x.Value).Take(3).ToList();

            string finalist = String.Join("", persons);

            var overall = Regex.Matches(finalist, patternForNames);



            Console.WriteLine($"1st place: {overall[0].ToString()}");
            Console.WriteLine($"2nd place: {overall[1].ToString()}");
            Console.WriteLine($"3rd place: {overall[2].ToString()}");




        }
    }
}
