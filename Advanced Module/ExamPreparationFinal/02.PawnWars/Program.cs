using System;
using System.Linq;
using System.Text;

namespace _02.PawnWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];
            var positionOfWhite = new int[2];
            var positionOfBlack = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string chars = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];

                    if (matrix[row, col] == 'w')
                    {
                        positionOfWhite = new int[2] { row, col };
                    }
                    else if (matrix[row, col] == 'b')
                    {
                        positionOfBlack = new int[2] { row, col };
                    }
                }


            }
            bool isWhiteTurn = false;

            

            while (true)
            {
                if (Math.Abs(positionOfWhite[0] - positionOfBlack[0]) == 1 && Math.Abs(positionOfWhite[1] - positionOfBlack[1]) == 1)
                {
                    if (isWhiteTurn)
                    {
                        
                        Console.WriteLine($"Game over! White capture on {GetPosition(positionOfBlack)}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! Black capture on {GetPosition(positionOfWhite)}.");
                        break;

                    }
                }


                if (positionOfWhite[0] > 0)
                {
                    matrix[positionOfWhite[0], positionOfWhite[1]] = '-';

                    positionOfWhite[0]--;
                    isWhiteTurn = true;
                    matrix[positionOfWhite[0], positionOfWhite[1]] = 'w';

                }
                if (positionOfWhite[0]==0)
                {

                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {GetPosition(positionOfWhite)}.");
                    break;
                }
                isWhiteTurn = false;

                if (Math.Abs(positionOfWhite[0] - positionOfBlack[0]) == 1 && Math.Abs(positionOfWhite[1] - positionOfBlack[1]) == 1)
                {
                    if (isWhiteTurn)
                    {

                        Console.WriteLine($"Game over! White capture on {GetPosition(positionOfBlack)}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! Black capture on {GetPosition(positionOfWhite)}.");
                        break;

                    }
                }

                if (positionOfBlack[0]<7)
                {
                    matrix[positionOfBlack[0], positionOfBlack[1]] = '-';
                    positionOfBlack[0]++;
                    isWhiteTurn = false;
                    matrix[positionOfBlack[0], positionOfBlack[1]] = 'b';


                }
                if (positionOfBlack[0]==7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {GetPosition(positionOfBlack)}.");
                    break;
                }

                //for (int i = 0; i < matrix.GetLength(0); i++)
                //{
                //    for (int j = 0; j < matrix.GetLength(1); j++)
                //    {
                //        Console.Write(matrix[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}
                isWhiteTurn = true;
                if (Math.Abs(positionOfWhite[0] - positionOfBlack[0])==1 && Math.Abs(positionOfWhite[1] - positionOfBlack[1]) == 1)
                {
                    if (isWhiteTurn)
                    {

                        Console.WriteLine($"Game over! White capture on {GetPosition(positionOfBlack)}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! Black capture on {GetPosition(positionOfWhite)}.");
                        break;

                    }
                }

            }




        }

        public static string GetPosition(int[] positionOfPawn)
        {
            StringBuilder position = new StringBuilder();
            char positionOfChar = (char)(positionOfPawn[1] + 97);
            position.Append(positionOfChar);
            position.Append(Math.Abs(positionOfPawn[0] - 8));

            return position.ToString();
        }
    }
}
