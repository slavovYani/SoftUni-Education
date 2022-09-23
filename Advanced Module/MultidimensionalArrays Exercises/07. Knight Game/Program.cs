using System;
using System.Linq;

namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte size = byte.Parse(Console.ReadLine());

            char[][] board = new char[size][];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                var currentArr = Console.ReadLine().ToCharArray();

                
                    board[row] = currentArr;
                
            }

            bool removedKnight = true;
            int knightsNeedToRemoved = 0;
            
            while (removedKnight == true)
            {
                if (size<3)
                {
                    removedKnight = false;
                }

                for (int row = 2; row < size - 2; row++)
                {
                    for (int col = 2; col < size - 2; col++)
                    {
                        if (board[row][col] == 'K')
                        {

                            if (board[row][col] == board[row + 1][col + 2] || board[row][col] == board[row - 1][col + 2] ||
                               board[row][col] == board[row + 2][col + 1] || board[row][col] == board[row + 2][col - 1] ||
                               board[row][col] == board[row - 2][col - 1] || board[row][col] == board[row - 2][col + 1] ||
                               board[row][col]== board[row + 1][col-2] || board[row][col]== board[row - 1][col-2])
                            {

                                removedKnight = true;
                                knightsNeedToRemoved++;
                                board[row][col] = '0';
                                row = 1;
                                col = 1;
                                break;

                            }

                            else
                            {

                                removedKnight = false;

                            }
                        }
                        else
                        {
                            removedKnight = false;
                        }
                    }
                }


            }

            Console.WriteLine(knightsNeedToRemoved);


        }
    }
}
