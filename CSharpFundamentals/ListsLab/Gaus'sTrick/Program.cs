using System;
using System.Collections.Generic;
using System.Linq;

namespace Gaus_sTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int length = numbers.Count;

            for (int i = 0; i < length / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
