using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToArray();
            }                            

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row+1].Length)
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] *= 2;
                    }
                    for (int i = 0; i < jaggedArray[row+1].Length; i++)
                    {
                        jaggedArray[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] /= 2;
                    }
                    for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                    {
                        jaggedArray[row + 1][i] /= 2;
                    }
                }
            }

            List<string> command = new List<string>();

            while (true)
            {
                command = Console.ReadLine()
                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();

                if (command[0].ToLower() == "end")
                {
                    break;
                }

                if (command[0].ToLower() == "add")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < jaggedArray.Length)
                    {
                        if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < jaggedArray[int.Parse(command[1])].Length)
                        {
                            jaggedArray[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                        }
                    }
                }
                else if (command[0].ToLower() == "subtract")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < jaggedArray.Length)
                    {
                        if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < jaggedArray[int.Parse(command[1])].Length)
                        {
                            jaggedArray[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                        }
                    }
                }
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
