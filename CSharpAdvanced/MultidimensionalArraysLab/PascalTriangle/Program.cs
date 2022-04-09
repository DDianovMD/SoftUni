using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] matrix = new long[rows][];

            // Fill Pascal's triangle

            if (rows == 1)
            {
                matrix[0] = new long[] { 1 };
            }
            else if (rows == 2)
            {
                matrix[0] = new long[] { 1 };
                matrix[1] = new long[] { 1, 1 };
            }
            else
            {
                matrix[0] = new long[] { 1 };
                matrix[1] = new long[] { 1, 1 };

                for (int row = 2; row < rows; row++)
                {
                    matrix[row] = new long[row + 1];
                    matrix[row][0] = 1;

                    for (int i = 1; i <= row; i++)
                    {
                        if (i < row)
                        {
                            matrix[row][i] = matrix[row - 1][i - 1] + matrix[row - 1][i];
                        }
                        else
                        {
                            matrix[row][i] = 1;
                        }
                    }
                }
            }

            // Print result

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
