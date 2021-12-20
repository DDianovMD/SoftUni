using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                string word1 = words[i];
                string word2 = words[rnd.Next(0, words.Count - 1)];

                words.Insert(i, word2);
                words.Insert(words.LastIndexOf(word2), word1);
                words.RemoveAt(words.LastIndexOf(word2));
                words.RemoveAt(i + 1);

            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
