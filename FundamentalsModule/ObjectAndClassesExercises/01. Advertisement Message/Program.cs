using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string>
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."
            };

            List<string> events = new List<string>
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            List<string> authors = new List<string>
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            List<string> cities = new List<string>
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            

            for (int i = 0; i < numberOfMessages; i++)
            {
                var randomIndex = new Random();
                int phrasesRandomIndex = randomIndex.Next(0, phrases.Count);
                int eventRandomIndex = randomIndex.Next(0, events.Count);
                int authorsRandomIndex = randomIndex.Next(0, authors.Count);
                int citiesRandomIndex = randomIndex.Next(0, cities.Count);
                Console.WriteLine($"{phrases[phrasesRandomIndex]} {events[eventRandomIndex]} {authors[authorsRandomIndex]} - {cities[citiesRandomIndex]}");
            }





        }

    }
    
}

