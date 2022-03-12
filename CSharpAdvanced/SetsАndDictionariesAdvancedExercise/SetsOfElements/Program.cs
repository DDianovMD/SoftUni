using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetsOfElements
{
    class Program
    {
        static void Main()
        {
            int[] setsCount = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            List<int> firstSet = new List<int>(setsCount[0]);
            List<int> secondSet = new List<int>(setsCount[1]);

            StringBuilder userInput = new StringBuilder();

            for (int i = 0; i < setsCount[0] + setsCount[1]; i++)
            {
                userInput.Append(Console.ReadLine());

                if (i < setsCount[0] && firstSet.Contains(int.Parse(userInput.ToString())) == false)
                {
                    firstSet.Add(int.Parse(userInput.ToString()));
                }
                else if(i >= setsCount[0] && secondSet.Contains(int.Parse(userInput.ToString())) == false)
                {
                    secondSet.Add(int.Parse(userInput.ToString()));
                }

                userInput.Clear();
            }

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
