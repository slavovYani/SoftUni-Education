using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var furnitures = new List<string>();
            string pattern = @">>(?<type>[a-zA-Z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>[0-9]+)";
           
           
            double totalPrice = 0; 
           

            var input = Console.ReadLine();
            


            while (input!="Purchase")
            {
                
                Match matches = Regex.Match(input,pattern,RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    var name = matches.Groups["type"].Value;
                   var price = double.Parse(matches.Groups["price"].Value);
                   var quantity = int.Parse(matches.Groups["quantity"].Value);
                   var priceProduct = price * quantity;
                   furnitures.Add(name);
                   totalPrice += priceProduct;
                }
                
                input = Console.ReadLine();

            }

           

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}
