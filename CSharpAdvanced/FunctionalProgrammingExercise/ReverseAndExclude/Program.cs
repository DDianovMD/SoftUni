using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numberToDivideWith = int.Parse(Console.ReadLine());

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % numberToDivideWith == 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
