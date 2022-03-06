using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main()
        {
            // Receive from user matrix's number of rows and columns.
            int[] rowsAndCols = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

            // Receive from user "snake" string.
            string snake = Console.ReadLine();

            Queue<char> snakeQueue = new Queue<char>();

            // Fill snakeQueue with given "snake" string's chars.
            foreach (var symbol in snake)
            {
                snakeQueue.Enqueue(symbol);
            }

            // Stack<char> used to reverse every 2nd row of the matrix.
            Stack<char> currentRowState = new Stack<char>();

            // Create matrix - array of queues.
            Queue<char>[] arrayOfCharQueue = new Queue<char>[rowsAndCols[0]];
            
            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                arrayOfCharQueue[row] = new Queue<char>();

                // Fill every row (queue) of the matrix.
                for (int col = 0; col < rowsAndCols[1]; col++)
                {
                    arrayOfCharQueue[row].Enqueue(snakeQueue.Peek());
                    snakeQueue.Enqueue(snakeQueue.Dequeue());
                }

                // Reverse every 2nd row using Stack<char> to save initial row state.
                if (row % 2 != 0)
                {
                    for (int i = 0; i < arrayOfCharQueue[row].Count; i++)
                    {
                       currentRowState.Push(arrayOfCharQueue[row].Peek());
                       arrayOfCharQueue[row].Enqueue(arrayOfCharQueue[row].Dequeue());
                    }

                    arrayOfCharQueue[row].Clear();

                    // Fill current row with reversed data (LIFO).
                    for (int i = 0; i < arrayOfCharQueue[row - 1].Count; i++) // using previous row.Count because we clear current one and it's Count == 0
                    {
                        arrayOfCharQueue[row].Enqueue(currentRowState.Pop());
                    }
                }
            }

            // Print result.
            foreach (var currentQueue in arrayOfCharQueue)
            {
                Console.WriteLine(string.Join("", currentQueue));
            }
        }
    }
}
