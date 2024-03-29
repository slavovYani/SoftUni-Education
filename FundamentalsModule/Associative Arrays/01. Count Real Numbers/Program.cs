﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number,0);
                }
                result[number]++;
            }
            foreach (var item in result)
            {

            Console.WriteLine($"{item.Key} -> {item.Value}");  
            }
        }
    }
}
