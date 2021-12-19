using System;
using System.Linq;
using System.Collections.Generic;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and used variables.
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> mixedList = new List<int>(firstList.Count + secondList.Count - 2);
            List<int> elementsInRange = new List<int>();

            int lowerRange;
            int upperRange;

            secondList.Reverse();

            // Mix 2 lists
            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                mixedList.Add(firstList[i]);
                firstList.RemoveAt(i);
                mixedList.Add(secondList[i]);
                secondList.RemoveAt(i);
                i--;
                
            }

            // Set range
            if (firstList.Count > 0)
            {
                if (firstList[0] < firstList[1])
                {
                    lowerRange = firstList[0];
                    upperRange = firstList[1];
                }
                else
                {
                    lowerRange = firstList[1];
                    upperRange = firstList[0];
                }
            }
            else
            {
                if (secondList[0] < secondList[1])
                {
                    lowerRange = secondList[0];
                    upperRange = secondList[1];
                }
                else
                {
                    lowerRange = secondList[1];
                    upperRange = secondList[0];
                }
            }

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > lowerRange && mixedList[i] < upperRange)
                {
                    elementsInRange.Add(mixedList[i]);
                }
            }

            elementsInRange.Sort();

            Console.WriteLine(string.Join(" ", elementsInRange));
        }
    }
}
