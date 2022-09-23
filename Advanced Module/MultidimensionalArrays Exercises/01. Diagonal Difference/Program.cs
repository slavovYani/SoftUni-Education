﻿using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows, cols];
            int leftSum = 0;
            int rightSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currArr[col];

                    if (row==col)
                    {
                        leftSum += matrix[row, col];
                    }


                }
                    rightSum += matrix[row,matrix.GetLength(0) - 1 - row];
            }

            Console.WriteLine(Math.Abs(leftSum-rightSum));

            
        }
    }
}
