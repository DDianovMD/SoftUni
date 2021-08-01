using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] holdingItems = new int[inputArray.Length];

                for (int j = 0; j < inputArray.Length; j++)
                {
                    holdingItems[j] = inputArray[j];
                }
                int holdItemZero = inputArray[0];

                for (int k = 0; k < inputArray.Length; k++)
                {
                    if (k != inputArray.Length - 1)
                    {
                        inputArray[k] = holdingItems[k + 1];
                    }                 
                }
                inputArray[inputArray.Length - 1] = holdItemZero;
            }

            foreach (var item in inputArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}