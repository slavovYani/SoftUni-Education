﻿using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
           string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            FinalResult(product,quantity);
            Console.WriteLine();
        }

        static void FinalResult(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;

            }
            double finalResult = (price * quantity);
            
            Console.WriteLine($"{finalResult:f2}");

        }

        
        

    }
}
