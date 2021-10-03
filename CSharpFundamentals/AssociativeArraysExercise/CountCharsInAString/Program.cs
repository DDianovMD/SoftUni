using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (var word in userInput)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (characters.ContainsKey(word[i]))
                    {
                        characters[word[i]]++;
                    }
                    else
                    {
                        characters.Add(word[i], 1);
                    }
                }                
            }

            foreach (var item in characters)
            {
                Console.WriteLine(string.Join(" ", item.Key + " -> " + item.Value));
            }
        }
    }
}
