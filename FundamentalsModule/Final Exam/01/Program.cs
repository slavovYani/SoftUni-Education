using System;
using System.Linq;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            var command = Console.ReadLine().Split().ToArray();

           

            while (command[0] !="End")
            {
                switch (command[0])
                {
                    case "Translate":
                        inputString = Translate(inputString,char.Parse(command[1]), char.Parse(command[2]));
                        Console.WriteLine(inputString);

                        break;

                    case "Includes":

                        Console.WriteLine(Includes(inputString, command[1]));

                        break;

                    case "Start":
                        Console.WriteLine(Start(inputString, command[1]));
                        
                        break;

                    case "Lowercase":
                        inputString = Lowercase(inputString);
                        Console.WriteLine(inputString);

                        break;

                    case "FindIndex":
                        Console.WriteLine(FindIndex(inputString, char.Parse(command[1])));
                        break;

                    case "Remove":
                        inputString = Remove(inputString, int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(inputString);
                        break;
                    
                }


                command = Console.ReadLine().Split();
            }

        }

        public static string Remove(string inputString, int startIndex, int count)
        {
            return inputString.Remove(startIndex, count);
        }

        public static int FindIndex(string inputString, char lastIndex)
        {
            return inputString.LastIndexOf(lastIndex);
        }

        public static string Lowercase(string inputString)
        {
            return inputString.ToLower();
        }

        public static bool Start(string inputString, string wordForCheck)
        {
            return inputString.StartsWith(wordForCheck);
        }

        public static bool Includes(string inputString, string wordForCheck)
        {
            return inputString.Contains(wordForCheck);
        }

        public static string Translate(string inputString,char original, char replacemant)
        {
             return inputString.Replace(original, replacemant);
            
        }
    }
}
