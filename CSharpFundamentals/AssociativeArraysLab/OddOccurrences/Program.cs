using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(" ");

            Dictionary<string, int> wordOccurence = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordOccurence.ContainsKey(word) == false)
                {
                    wordOccurence.Add(word, 1);
                }
                else
                {
                    wordOccurence[word]++;
                }
            }

            foreach (var word in wordOccurence)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
