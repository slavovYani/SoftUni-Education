using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];
            int sum = 0;
            int maxSum = int.MinValue;
            int maxStartIndexRow = 0;
            int maxStartIndexCol = 0;
            int[,] maxMatrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currArr[col];
                }
            }



            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {

                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];


                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        maxStartIndexRow = row;
                        maxStartIndexCol = col;

                        
                    }

                }


            }



            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxStartIndexRow; row <= maxMatrix.GetLength(0); row++)
            {
                for (int col = maxStartIndexCol; col <= maxMatrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
