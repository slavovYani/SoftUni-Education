using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfRotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotation; i++)
            {
                int temporaryNumberFromAray = originalArray[0];

                for (int j = 0; j < originalArray.Length-1; j++)
                {
                originalArray[j] = originalArray[j+1];

                }
                originalArray[originalArray.Length - 1] = temporaryNumberFromAray;
            }

            Console.WriteLine(String.Join(" ", originalArray));

        }
    }
}
