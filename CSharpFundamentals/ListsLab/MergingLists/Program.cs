using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int index1 = 1;
            int index2 = 0;

            for (int i = 0; i < firstList.Count + secondList.Count; i++)
            {
                result.Add(0);
            }

            result[0] = firstList[0];

            if (firstList.Count <= secondList.Count)
            {
                for (int i = 1; i < result.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        result[i] = secondList[index2];
                        index2++;
                    }
                    else if (i % 2 == 0 && index1 < firstList.Count)
                    {
                        result[i] = firstList[index1];
                        index1++;
                    }
                    else if (i % 2 == 0 && index1 >= firstList.Count)
                    {
                        result[i] = secondList[index2];
                        index2++;
                    }
                }
            }
            else
            {
                for (int i = 1; i < result.Count; i++)
                {
                    if (i % 2 != 0 && index2 < secondList.Count)
                    {
                        result[i] = secondList[index2];
                        index2++;
                    }
                    else if (i % 2 != 0 && index2 >= secondList.Count)
                    {
                        result[i] = firstList[index1];
                        index1++;
                    }
                    else if (i % 2 == 0)
                    {
                        result[i] = firstList[index1];
                        index1++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
