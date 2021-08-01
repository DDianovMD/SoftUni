using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysLength = int.Parse(Console.ReadLine());

            int[] firstArray = new int[arraysLength];
            int[] secondArray = new int[arraysLength];

            for (int i = 1; i <= arraysLength; i++)
            {
                int[] userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i - 1] = userInput[1];
                    secondArray[i - 1] = userInput[0];
                }
                else
                {
                    firstArray[i - 1] = userInput[0];
                    secondArray[i - 1] = userInput[1];
                }
            }

            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }           
        }
    }
}
