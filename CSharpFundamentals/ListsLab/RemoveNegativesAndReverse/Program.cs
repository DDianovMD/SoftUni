﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            if (numbers.Count > 0)
            {

                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));

            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
