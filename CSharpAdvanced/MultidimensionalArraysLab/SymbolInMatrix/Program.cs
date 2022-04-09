using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main()
        {
            // Receive matrix's rows and cols

            int rowsAndCols = int.Parse(Console.ReadLine());


            // Create matrix

            char[,] matrix = new char[rowsAndCols, rowsAndCols];

            // Fill matrix

            for (int rows = 0; rows < rowsAndCols; rows++)
            {
                string currentDimension = Console.ReadLine();

                for (int col = 0; col < currentDimension.Length; col++)
                {
                    matrix[rows, col] = currentDimension[col];
                }
            }

            char searchedSymbol = char.Parse(Console.ReadLine());

            bool isFound = false;
            int symbolRow = int.MinValue;
            int symbolCol = int.MinValue;

            // Search for given symbol

            for (int row = 0; row < rowsAndCols; row++)
            {
                for (int col = 0; col < rowsAndCols; col++)
                {
                    if (matrix[row,col] == searchedSymbol)
                    {
                        isFound = true;
                        symbolRow = row;
                        symbolCol = col;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            // Print result

            if (isFound)
            {
                Console.WriteLine($"({symbolRow}, {symbolCol})");
            }
            else
            {
                Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
            }
        }
    }
}
