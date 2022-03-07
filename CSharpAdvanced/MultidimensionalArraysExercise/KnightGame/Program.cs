using System;

namespace KnightGame
{
    class Program
    {
        static void Main()
        {
            /* Problem description:
             
               You will receive a board with K for knights and '0' for empty cells.
               Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.
               Print a single integer with the minimum number of knights that needs to be removed.
            */

            /*  Problem solution:

                Possible moves:
                1.  1 up -> 2 left      => [row - 1, col - 2]
                2.  1 up -> 2 right     => [row - 1, col + 2]
                3.  1 down -> 2 left    => [row + 1, col - 2]
                4.  1 down -> 2 right   => [row + 1, col + 2]
                5.  2 up -> 1 left      => [row - 2, col - 1]
                6.  2 up -> 1 right     => [row - 2, col + 1]
                7.  2 down -> 1 left    => [row + 2, col - 1]
                8.  2 down -> 1 right   => [row + 2, col + 1]
             
            */

            int boardSide = int.Parse(Console.ReadLine());

            string[,] board = new string[boardSide, boardSide];

            // Filling the board
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = currentRow[col].ToString();
                }
            }

            int knightsInDangerCounter = 0; // Counting how many knights can be attacked from current knight.
            int removedKnightsCounter = 0; // Counting removed knights from the board.

            for (int maxAttackPotential = 8; maxAttackPotential > 0; maxAttackPotential--) // Every knight can attack and kill maximum 8 other knights. P.S. Check "Possible moves" at the beginning.
            {
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col].ToLower() == "k") // Check if we have knight on current position.
                        {
                            // Check if new position isn't outside of the board (so we don't get IndexOutOfRangeException).
                            if (row - 1 >= 0)
                            {
                                if (col - 2 >= 0)
                                {
                                    // Check if there is knight to be attacked on the new possition.
                                    if (board[row - 1, col - 2].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }

                                if (col + 2 < board.GetLength(1))
                                {
                                    // Check if there is knight to be attacked on the new possition.
                                    if (board[row - 1, col + 2].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }
                            }

                            if (row + 1 < board.GetLength(0))
                            {
                                if (col - 2 >= 0)
                                {
                                    // Check if there is knight to be attacked on the new possition
                                    if (board[row + 1, col - 2].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }

                                if (col + 2 < board.GetLength(1))
                                {
                                    // Check if there is knight to be attacked on the new possition
                                    if (board[row + 1, col + 2].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }
                            }

                            if (row - 2 >= 0)
                            {
                                if (col - 1 >= 0)
                                {
                                    // Check if there is knight to be attacked on the new possition
                                    if (board[row - 2, col - 1].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }

                                if (col + 1 < board.GetLength(1))
                                {
                                    // Check if there is knight to be attacked on the new possition
                                    if (board[row - 2, col + 1].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }
                            }

                            if (row + 2 < board.GetLength(0))
                            {
                                if (col - 1 >= 0)
                                {
                                    // Check if there is knight to be attacked on the new possition
                                    if (board[row + 2, col - 1].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }

                                if (col + 1 < board.GetLength(1))
                                {
                                    // Check if there is knight to be attacked on the new possition
                                    if (board[row + 2, col + 1].ToLower() == "k")
                                    {
                                        knightsInDangerCounter++;
                                    }
                                }
                            }
                        }

                        // Check if every possible attack is against another knight (attack potential of current knight is biggest possible)
                        if (knightsInDangerCounter == maxAttackPotential)
                        {
                            board[row, col] = "0"; // Remove knight from board.
                            removedKnightsCounter++;
                        }

                        knightsInDangerCounter = 0; // Restart counter.
                    }
                }
            }

            // Print result
            Console.WriteLine(removedKnightsCounter);
        }
    }
}
