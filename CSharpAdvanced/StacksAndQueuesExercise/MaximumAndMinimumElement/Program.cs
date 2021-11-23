using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            int[] currentQuery = new int[2];

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                 currentQuery = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                if (currentQuery[0] == 1)
                {
                    stackOfNumbers.Push(currentQuery[1]);
                }
                else if (currentQuery[0] == 2)
                {
                    if (stackOfNumbers.Count > 0)
                    {
                        stackOfNumbers.Pop();
                    }                    
                }
                else if (currentQuery[0] == 3 && stackOfNumbers.Count > 0)
                {
                    Console.WriteLine(stackOfNumbers.Max());
                }
                else if (currentQuery[0] == 4 && stackOfNumbers.Count > 0)
                {
                    Console.WriteLine(stackOfNumbers.Min());
                }
            }

            for (int i = 0; i < stackOfNumbers.Count; i++)
            {
                if (i != stackOfNumbers.Count - 1)
                {
                    Console.Write($"{stackOfNumbers.Peek()}, ");
                    stackOfNumbers.Pop();
                    i--;
                }
                else
                {
                    Console.Write($"{stackOfNumbers.Peek()}");
                    stackOfNumbers.Pop();
                    i--;
                }
            }
        }
    }
}
