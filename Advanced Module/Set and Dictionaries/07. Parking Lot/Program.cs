using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            HashSet<string> carNumbers = new HashSet<string>();

            while (input[0] != "END")
            {
                string command = input[0];
                string number = input[1];

                if (command == "IN")
                {

                    carNumbers.Add(number);
                }
                else
                {
                    carNumbers.Remove(number);
                }
                input = Console.ReadLine().Split(", ");

            }

            if (!carNumbers.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var carNumber in carNumbers)
            {
                Console.WriteLine(carNumber);
            }
        }
    }
}
