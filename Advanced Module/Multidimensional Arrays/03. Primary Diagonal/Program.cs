using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());

            int rows = sizeOfSquareMatrix;
            int cols = sizeOfSquareMatrix;

            int[,] matrix = new int[rows, cols];
            int diagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currArr[col];

                    if (col==row)
                    {
                        diagonalSum+=matrix[row, col];
                    }
                }
            }
            Console.WriteLine(diagonalSum);

        }
    }
}
