using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<string> periodicTable = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] currentInput = Console.ReadLine()
                                               .Split(" ")
                                               .ToArray();

                foreach (var element in currentInput)
                {
                    if (periodicTable.Contains(element) == false)
                    {
                        periodicTable.Add(element);
                    }
                }
            }

            periodicTable.Sort();

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
