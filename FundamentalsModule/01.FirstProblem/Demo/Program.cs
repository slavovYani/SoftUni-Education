using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listWithCoffies = Console.ReadLine().Split().ToList();

            listWithCoffies.Insert(1, "Lava");
        }
    }
}
