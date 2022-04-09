using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            List<string> command = new List<string>();

            // Modify array

            while (true)
            {
                command = Console.ReadLine().Split(" ").ToList();

                if (command[0].ToUpper() == "END")
                {
                    break;
                }
                else if (command[0].ToLower() == "add")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < rows && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix.GetLength(0))
                    {
                        matrix[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid coordinates");
                    }
                }
                else if (command[0].ToLower() == "subtract")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < rows && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix.GetLength(0))
                    {
                        matrix[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid coordinates");
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
