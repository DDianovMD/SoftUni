using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> numbersOccurance = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbersOccurance.ContainsKey(numbers[i]))
                {
                    numbersOccurance[numbers[i]]++;
                }
                else
                {
                    numbersOccurance.Add(numbers[i], 1);
                }
            }

            foreach (var number in numbersOccurance)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
