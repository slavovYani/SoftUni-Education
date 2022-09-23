using System;
using System.ComponentModel;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];
            int squareEqualCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currArr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currArr[col];
                }
            }

            
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        char currElement = matrix[row, col];

                        if (currElement == matrix[row, col + 1] && currElement == matrix[row + 1, col] && currElement == matrix[row + 1, col + 1])
                        {
                            squareEqualCells++;
                        }

                    }
                }

                Console.WriteLine(squareEqualCells);

            

            
            
        }
    }
}
