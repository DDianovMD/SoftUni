using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            int[] borders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbersInRange = new List<int>();

            for (int i = borders[0]; i <= borders[1]; i++)
            {
                numbersInRange.Add(i);
            }

            string searchCriteria = Console.ReadLine();

            if (searchCriteria.ToLower() == "even")
            {
                foreach (var num in numbersInRange)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            else
            {
                foreach (var num in numbersInRange)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
        }
    }
}
