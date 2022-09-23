using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> guestVIP = new HashSet<string>();
            HashSet<string> guestRegular = new HashSet<string>();

            while (input != "END")
            {
                char firstChar = input[0];
                if (input == "PARTY")
                {
                    while (input != "END")
                    {
                        input = Console.ReadLine();
                        firstChar = input[0];

                        IsVIPorRegularRemoving(input, guestVIP, guestRegular, firstChar);
                    }

                }
                else
                {
                    IsVIPorRegularAdding(input, guestVIP, guestRegular, firstChar);

                }

                if (input=="END")
                {
                    break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(guestRegular.Count+guestVIP.Count);

            foreach (var vip in guestVIP)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in guestRegular)
            {
                Console.WriteLine(regular);
            }
        }

        private static void IsVIPorRegularAdding(string input, HashSet<string> guestVIP, HashSet<string> guestRegular, char firstChar)
        {
            if (char.IsDigit(firstChar))
            {
                guestVIP.Add(input);
            }
            else if (char.IsLetter(firstChar))
            {
                guestRegular.Add(input);
            }
        }

        private static void IsVIPorRegularRemoving(string input, HashSet<string> guestVIP, HashSet<string> guestRegular, char firstChar)
        {
            if (char.IsDigit(firstChar))
            {
                guestVIP.Remove(input);
            }
            else if (char.IsLetter(firstChar))
            {
                guestRegular.Remove(input);
            }
        }
    }
}
