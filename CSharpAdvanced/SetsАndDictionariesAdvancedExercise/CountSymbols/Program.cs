using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main()
        {
            string userInput = Console.ReadLine();

            Dictionary<int, int> characterCount = new Dictionary<int, int>();

            for (int i = 0; i < userInput.Length; i++)
            {
                if (characterCount.ContainsKey((int)userInput[i]) == false)
                {
                    characterCount.Add((int)userInput[i], 1);
                }
                else
                {
                    characterCount[(int)userInput[i]] += 1;
                }
            }

            foreach (var charAsNum in characterCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{(char)charAsNum.Key}: {charAsNum.Value} time/s");
            }
        }
    }
}
