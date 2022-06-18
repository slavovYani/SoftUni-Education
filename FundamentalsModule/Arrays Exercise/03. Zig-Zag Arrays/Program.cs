using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArrays = int.Parse(Console.ReadLine());
            int[] firstArray = new int[sizeOfArrays];
            int[] secondArray = new int[sizeOfArrays];

            for (int i = 0; i < sizeOfArrays; i++)
            {
                int[] temporaryArray = Console.ReadLine().Split().Select(int.Parse).ToArray();


                if (i % 2 ==0)
                {
                    firstArray[i] = temporaryArray[0];
                    secondArray[i] = temporaryArray[1];
                }
                else
                {
                    firstArray[i] = temporaryArray[1];
                    secondArray[i] = temporaryArray[0];
                }
          
            }
            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
        
    }
}
