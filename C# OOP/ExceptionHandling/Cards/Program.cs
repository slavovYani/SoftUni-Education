using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Card card = new Card();

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string[] faceAndSuit = input[i].Split();

                    string face = faceAndSuit[0];
                    string suit = faceAndSuit[1];

                    card.AddValidCard(face, suit);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    
                }
                
            }

            Console.WriteLine(card);
        }
    }


    public class Card
    {
        public Card()
        {
            Cards = new Dictionary<string, char>();
        }
        private static readonly string[] faces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        private static readonly Dictionary<string, char> suits = new Dictionary<string, char>
        {
            { "S", '\u2660' },
            { "H", '\u2665' },
            { "D", '\u2666' },
            { "C", '\u2663' },
        };

        public Dictionary<string, char> Cards { get; private set; }

        public void AddValidCard(string face, string suit)
        {
            if (!faces.Contains(face) || !(suits.ContainsKey(suit)))
            {
                throw new ArgumentException("Invalid card!");
            }

            this.Cards.Add(face, suits[suit]);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Cards)
            {
                sb.Append($"[{item.Key + item.Value}] ");
            }
            return sb.ToString().TrimEnd();
        }


    }


}
