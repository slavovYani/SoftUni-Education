using System;
using System.Text.RegularExpressions;

namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

            int numberOfLine = int.Parse(Console.ReadLine());
            var regex = new Regex(pattern);


            for (int i = 0; i < numberOfLine; i++)
            {
                var input = Console.ReadLine();
                
                if (regex.Match(input).Success)
                {
                    var name = regex.Match(input).Groups["name"].Value;
                    var title = regex.Match(input).Groups["title"].Value;
                    var strenght = name.Length;
                    var armor = title.Length;

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {strenght}");
                    Console.WriteLine($">> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine($"Access denied!");
                }

            }
        }
    }
}
