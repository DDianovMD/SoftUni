using System;
using System.Collections.Generic;

namespace PawnWars
{
    public class Program
    {
        public static char[,] matrix = new char[8, 8];
        public static Dictionary<int, char> columnNames = new Dictionary<int, char>();
        public static int whitePawnRow;
        public static int whitePawnColumn;
        public static int blackPawnRow;
        public static int blackPawnColumn;
        public static bool isCaptured = false;
        public static bool isWon = false;

        public static void Main()
        {
            columnNames.Add(0, 'a');
            columnNames.Add(1, 'b');
            columnNames.Add(2, 'c');
            columnNames.Add(3, 'd');
            columnNames.Add(4, 'e');
            columnNames.Add(5, 'f');
            columnNames.Add(6, 'g');
            columnNames.Add(7, 'h');

            // Fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'w')
                    {
                        whitePawnRow = row;
                        whitePawnColumn = col;
                    }
                    else if (rowData[col] == 'b')
                    {
                        blackPawnRow = row;
                        blackPawnColumn = col;
                    }
                }
            }

            // Program logic
            while (isCaptured == false && isWon == false)
            {
                WhitePawnMove();

                if (isCaptured || isWon)
                {
                    break;
                }

                BlackPawnMove();
            }
        }

        // Methods
        public static void WhitePawnMove()
        {
            matrix[whitePawnRow, whitePawnColumn] = '-';
            whitePawnRow -= 1;

            if (whitePawnColumn - 1 >= 0)
            {
                if (matrix[whitePawnRow, whitePawnColumn - 1] == 'b')
                {
                    whitePawnColumn -= 1;
                    isCaptured = true;
                }
            }

            if (whitePawnColumn + 1 < matrix.GetLength(1))
            {
                if (matrix[whitePawnRow, whitePawnColumn + 1] == 'b')
                {
                    whitePawnColumn += 1;
                    isCaptured = true;
                }
            }

            matrix[whitePawnRow, whitePawnColumn] = 'w';

            if (whitePawnRow == 0)
            {
                isWon = true;
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {columnNames[whitePawnColumn]}{Math.Abs(whitePawnRow - 8)}.");
            }
            else if (isCaptured)
            {
                Console.WriteLine($"Game over! White capture on {columnNames[whitePawnColumn]}{Math.Abs(whitePawnRow - 8)}.");
            }
        }

        public static void BlackPawnMove()
        {
            matrix[blackPawnRow, blackPawnColumn] = '-';
            blackPawnRow += 1;

            if (blackPawnColumn - 1 >= 0)
            {
                if (matrix[blackPawnRow, blackPawnColumn - 1] == 'w')
                {
                    blackPawnColumn -= 1;
                    isCaptured = true;
                }
            }

            if (blackPawnColumn + 1 < matrix.GetLength(1))
            {
                if (matrix[blackPawnRow, blackPawnColumn + 1] == 'w')
                {
                    blackPawnColumn += 1;
                    isCaptured = true;
                }
            }

            matrix[blackPawnRow, blackPawnColumn] = 'b';

            if (blackPawnRow == 7)
            {
                isWon = true;
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {columnNames[blackPawnColumn]}{Math.Abs(blackPawnRow - 8)}.");
            }
            else if (isCaptured)
            {
                Console.WriteLine($"Game over! Black capture on {columnNames[blackPawnColumn]}{Math.Abs(blackPawnRow - 8)}.");
            }
        }
    }
}
