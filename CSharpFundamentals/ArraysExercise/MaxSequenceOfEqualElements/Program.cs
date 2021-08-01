using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentLength = 1;
            int bestIndex = 0;
            int bestLength = 0;          

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        currentLength += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestLength < currentLength)
                {
                    bestLength = currentLength;
                    bestIndex = i;
                }

                currentLength = 1;
            }

            for (int k = 0; k < bestLength; k++)
            {
                Console.Write(inputArray[bestIndex] + " ");
            }
        }
    }
}