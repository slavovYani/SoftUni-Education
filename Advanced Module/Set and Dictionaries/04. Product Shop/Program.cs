﻿using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string,double>> shops = new SortedDictionary<string, Dictionary<string,double>>();

            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            while (input[0]!="Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());

                }

                shops[shop].Add(product, price);



                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            }

            foreach (var shop in shops)
            {
                Console.WriteLine(shop.Key + "->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
