﻿using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                
               

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }


                continents[continent][country].Add(city);

            }

            foreach (var continent in continents)
            {
                Console.WriteLine(continent.Key+":");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($" {country.Key} -> {String.Join(", ",country.Value)}");
                }
            }
        }
    }
}
