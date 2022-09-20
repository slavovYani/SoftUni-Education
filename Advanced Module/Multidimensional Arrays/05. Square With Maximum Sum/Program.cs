using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];
            int counter = 1;
            int maxSum = 0;
            int currentSum = 0;

            int[,] maxSumSquare = new int[2, 2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentCol[col];
                }

            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        maxSumSquare = new int[2, 2] 
                        {   { matrix[row,col], matrix[row,col+1] },

                            { matrix[row+1,col], matrix[row+1,col+1] }
                        };


                    }
                    currentSum = 0;


                }

            }

            for (int row = 0; row < maxSumSquare.GetLength(0); row++)
            {
                for (int col = 0; col < maxSumSquare.GetLength(1); col++)
                {
                    Console.Write(maxSumSquare[row, col] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine(maxSum);
        }
    }
}
