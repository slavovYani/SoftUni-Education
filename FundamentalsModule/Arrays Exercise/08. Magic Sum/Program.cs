using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int desiredSum = int.Parse(Console.ReadLine());
            int startNum = 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = startNum; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == desiredSum)
                    {
                        Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
                    }

                }
                startNum++;
                
            }

        }
    }
}
