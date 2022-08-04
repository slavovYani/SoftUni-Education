using System;
using System.Linq;

namespace _01.Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            foreach (var username in input)
            {
               bool isValid = true;

                if (username.Length>=3 && username.Length<=16)
                {

                    for (int i = 0; i < username.Length; i++)
                    {
                        char currentChar = username[i];

                        if (!(currentChar == '-'|| currentChar== '_' || char.IsLetterOrDigit(currentChar)))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }


                
            }

        }
    }
}
