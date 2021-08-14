using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRows = int.Parse(Console.ReadLine());
            int[] savedLastRow = new int[maxRows];

            for (int row = 0; row < maxRows; row++)
            {
                int[] currentRow = new int[row + 1];

                for (int i = 0; i < currentRow.Length; i++)
                {
                    if (row == 0)
                    {
                        currentRow[i] = 1;
                    }
                    else if (row == 1)
                    {
                        for (int j = 0; j <= row; j++)
                        {
                            currentRow[j] = 1;
                        }
                    }
                    else if (row > 1 && row % 2 == 0)
                    {
                        for (int k = 0; k <= currentRow.Length / 2; k++) // fill first half of the row + middle item
                        {
                            if (k == 0)
                            {
                                currentRow[k] = 1;
                            }
                            else
                            {
                                currentRow[k] = savedLastRow[k - 1] + savedLastRow[k];
                            }
                        }
                        int counter = 0;
                        for (int l = currentRow.Length - 1; l > currentRow.Length / 2; l--) // fill second half of the row
                        {
                            currentRow[l] = currentRow[counter];
                            counter++;
                        }
                    }
                    else if (row > 1 && row % 2 == 1)
                    {
                        for (int m = 0; m < currentRow.Length / 2; m++) // fill first half of the row
                        {
                            if (m == 0)
                            {
                                currentRow[m] = 1;
                            }
                            else
                            {
                                currentRow[m] = savedLastRow[m - 1] + savedLastRow[m];
                            }
                        }
                        int counter = 0;
                        for (int n = currentRow.Length - 1; n >= currentRow.Length / 2; n--) // fill second half of the row
                        {
                            currentRow[n] = currentRow[counter];
                            counter++;
                        }

                    }

                    for (int z = 0; z < currentRow.Length; z++) // print current row of Pascal's triangle
                    {
                        if (z != currentRow.Length - 1)
                        {
                            Console.Write($"{currentRow[z]} ");
                        }
                        else
                        {
                            Console.WriteLine(currentRow[z]);
                        }
                    }

                    for (int f = 0; f < currentRow.Length; f++)
                    {
                        savedLastRow[f] = currentRow[f];
                    }
                    break;
                }
            }

        }
    }
}
