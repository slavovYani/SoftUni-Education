using System;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (var stringsInFirst in firstArray)
            {
                foreach (var stringsInSecond in secondArray)
                {
                    if (stringsInFirst==stringsInSecond)
                    {
                        Console.Write(stringsInFirst+ " ");
                    }
                    
                }
            }
        }
    }
}
