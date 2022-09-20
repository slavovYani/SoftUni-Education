using System;

namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = 1;

            long[][] pascalTriangle = new long[rows][];


            for (int row = 0; row < rows; row++)
            {
                long[] currArr = new long[cols];


                for (int col = 0; col < currArr.Length; col++)
                {
                    if (col == 0)
                    {
                        currArr[col] = 1;
                    }
                    else if (col == 1 && row == 1)
                    {
                        currArr[col] = col;
                    }
                    else
                    {
                        if (col != currArr.Length - 1)
                        {
                            currArr[col] = pascalTriangle[row - 1][col] + pascalTriangle[row - 1][col - 1];

                        }
                        else
                        {
                            currArr[col] = 1;
                        }

                    }

                    pascalTriangle[row] = currArr;

                }
                cols++;

            }

            for (int row = 0; row < pascalTriangle.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ",pascalTriangle[row]));
            }

        }
    }
}
