using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userInput = Console.ReadLine().Split('|').ToArray();
            List<int> output = new List<int>();
            string currentArray = string.Empty;

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                currentArray = userInput[i];
                List<int> temporaryList = currentArray
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < temporaryList.Count; j++)
                {
                    output.Add(temporaryList[j]);
                }
            }

            Console.WriteLine(string.Join(" ", output));
            
        }
    }
}