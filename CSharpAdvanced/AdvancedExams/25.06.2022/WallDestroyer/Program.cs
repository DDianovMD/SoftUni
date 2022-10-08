using System;

namespace WallDestroyer
{
    public class Program
    {
        static void Main()
        {
            // Get matrix row and column size
            int matrixSize = int.Parse(Console.ReadLine());

            // Create matrix with given sizes
            char[,] matrix = new char[matrixSize, matrixSize];

            // Used variables for program logic
            int currentRow = int.MinValue;
            int currentColumn = int.MinValue;
            int holesCounter = 1;
            int hitRodsCounter = 0;
            bool gotElectrocuted = false;

            // Fill each matrix row with given data
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRowData[col];

                    if (currentRowData[col] == 'V')
                    {
                        currentRow = row;
                        currentColumn = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "up")
                {
                    int newRow = currentRow - 1;
                    // Check if new index is inside the matrix
                    if (newRow >= 0)
                    {
                        if (matrix[newRow, currentColumn] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRodsCounter++;
                        }
                        else if (matrix[newRow, currentColumn] == 'C')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            matrix[newRow, currentColumn] = 'E';
                            holesCounter++;
                            gotElectrocuted = true;
                            break;
                        }
                        else if (matrix[newRow, currentColumn] == '*')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            currentRow = newRow;
                            Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentColumn}]!");
                            matrix[currentRow, currentColumn] = 'V';
                        }
                        else
                        {
                            matrix[currentRow, currentColumn] = '*';
                            holesCounter++;
                            currentRow = newRow;
                            matrix[currentRow, currentColumn] = 'V';
                        }
                    }
                }
                else if (command == "down")
                {
                    int newRow = currentRow + 1;
                    // Check if new index is inside the matrix
                    if (newRow < matrix.GetLength(0))
                    {
                        if (matrix[newRow, currentColumn] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRodsCounter++;
                        }
                        else if (matrix[newRow, currentColumn] == 'C')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            matrix[newRow, currentColumn] = 'E';
                            holesCounter++;
                            gotElectrocuted = true;
                            break;
                        }
                        else if (matrix[newRow, currentColumn] == '*')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            currentRow = newRow;
                            Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentColumn}]!");
                            matrix[currentRow, currentColumn] = 'V';
                        }
                        else
                        {
                            matrix[currentRow, currentColumn] = '*';
                            holesCounter++;
                            currentRow = newRow;
                            matrix[currentRow, currentColumn] = 'V';
                        }
                    }
                }
                else if (command == "left")
                {
                    int newColumn = currentColumn - 1;
                    // Check if new index is inside the matrix
                    if (newColumn >= 0)
                    {
                        if (matrix[currentRow, newColumn] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRodsCounter++;
                        }
                        else if (matrix[currentRow, newColumn] == 'C')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            matrix[currentRow, newColumn] = 'E';
                            holesCounter++;
                            gotElectrocuted = true;
                            break;
                        }
                        else if (matrix[currentRow, newColumn] == '*')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            currentColumn = newColumn;
                            Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentColumn}]!");
                            matrix[currentRow, currentColumn] = 'V';
                        }
                        else
                        {
                            matrix[currentRow, currentColumn] = '*';
                            holesCounter++;
                            currentColumn = newColumn;
                            matrix[currentRow, currentColumn] = 'V';
                        }
                    }
                }
                else if (command == "right")
                {
                    int newColumn = currentColumn + 1;
                    // Check if new index is inside the matrix
                    if (newColumn < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, newColumn] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRodsCounter++;
                        }
                        else if (matrix[currentRow, newColumn] == 'C')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            matrix[currentRow, newColumn] = 'E';
                            holesCounter++;
                            gotElectrocuted = true;
                            break;
                        }
                        else if (matrix[currentRow, newColumn] == '*')
                        {
                            matrix[currentRow, currentColumn] = '*';
                            currentColumn = newColumn;
                            Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentColumn}]!");
                            matrix[currentRow, currentColumn] = 'V';
                        }
                        else
                        {
                            matrix[currentRow, currentColumn] = '*';
                            holesCounter++;
                            currentColumn = newColumn;
                            matrix[currentRow, currentColumn] = 'V';
                        }
                    }
                }

                command = Console.ReadLine();
            }

            // Print output
            if (gotElectrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCounter} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holesCounter} hole(s) and he hit only {hitRodsCounter} rod(s).");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
