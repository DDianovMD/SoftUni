using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main()
        {
            Dictionary<double, int> valuesCounter = new Dictionary<double, int>();

            double[] values = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(double.Parse)
                                     .ToArray();

            foreach (var value in values)
            {
                if (valuesCounter.ContainsKey(value) == false)
                {
                    valuesCounter.Add(value, 1);
                }
                else
                {
                    valuesCounter[value]++;
                }
            }

            foreach (var kvp in valuesCounter)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
