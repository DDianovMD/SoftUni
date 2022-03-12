using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main()
        {
            int upperBorder = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 1; i <= upperBorder; i++)
            {
                numbers.Add(i);
            }

            int[] predicates = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

            bool isDividable = true;

            List<int> filteredNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < predicates.Length; j++)
                {
                    if (numbers[i] % predicates[j] != 0)
                    {
                        isDividable = false;
                    }
                }

                if (isDividable)
                {
                    filteredNumbers.Add(numbers[i]);
                }

                isDividable = true;
            }

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}
