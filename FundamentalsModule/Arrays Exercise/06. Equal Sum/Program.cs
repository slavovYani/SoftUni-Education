using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum =0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray.Length==1)
                {
                    Console.WriteLine(0);
                    return;
               
                }
                leftSum = 0;

                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextLeftElementPosition = sumLeft - 1;
                    if (sumLeft>0)
                    {
                        leftSum += inputArray[nextLeftElementPosition];
                    }
                }

                rightSum = 0;

                for (int j = i; j < inputArray.Length; j++)
                {
                    int nextElementPosition = j + 1;
                    if (j<inputArray.Length-1)
                    {
                        rightSum += inputArray[nextElementPosition];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
            



        }
    }
}
