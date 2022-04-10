using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            numbers = numbers.OrderByDescending(x => x).ToArray();

            if (numbers.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
