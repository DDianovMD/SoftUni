using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (smallestNumber > numbers[i])
                {
                    smallestNumber = numbers[i];
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
