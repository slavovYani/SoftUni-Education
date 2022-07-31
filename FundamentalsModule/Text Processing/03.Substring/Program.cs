using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string mainString = Console.ReadLine();

            while (mainString.Contains(stringToRemove))
            {
                int startIndex = mainString.IndexOf(stringToRemove);
                mainString = mainString.Remove(startIndex, stringToRemove.Length);
            }
            Console.WriteLine(mainString);
        }
    }
}
