using System;
using System.Text;

namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder(Console.ReadLine());

            string[] command = Console.ReadLine().Split(":");
            string mainComand = command[0];


            while (mainComand != "Travel")
            {

                switch (mainComand)
                {
                    case "Add Stop":
                        input = AddStop(input, command);

                        break;

                    case "Remove Stop":
                        RemoveStop(input, command);

                        break;
                    case "Switch":
                        Switch(input, command);

                        break;



                }
                command = Console.ReadLine().Split(":");
                mainComand = command[0];

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }

        private static StringBuilder AddStop(StringBuilder input, string[] command)
        {
            int indexToInsert = int.Parse(command[1]);
            string stringToInsert = command[2];

            if (indexToInsert <= input.MaxCapacity && indexToInsert >= 0)
            {
                input = input.Insert(indexToInsert, stringToInsert);
            }
            Console.WriteLine(input);
            return input;
        }

        private static void Switch(StringBuilder input, string[] command)
        {
            string inputString = input.ToString();

            if (inputString.Contains(command[1]))
            {
                input.Replace(command[1], command[2]);
            }
            Console.WriteLine(input);
        }

        private static void RemoveStop(StringBuilder input, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            int count = endIndex - startIndex + 1;

            if (startIndex < input.Length && endIndex < input.Length && startIndex >= 0 && endIndex >= 0)
            {

                input.Remove(startIndex, count);
            }
            Console.WriteLine(input);
        }
    }
}
