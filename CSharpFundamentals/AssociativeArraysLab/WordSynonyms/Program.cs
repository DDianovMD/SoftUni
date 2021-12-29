using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            string word = string.Empty;
            string synonym = string.Empty;

            Dictionary<string, List<string>> wordAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                word = Console.ReadLine();
                synonym = Console.ReadLine();

                if (wordAndSynonyms.ContainsKey(word) == false)
                {
                    wordAndSynonyms.Add(word, new List<string> { synonym });
                }
                else
                {
                    wordAndSynonyms[word].Add(synonym);
                }

                word = string.Empty;
                synonym = string.Empty;
            }

            foreach (var item in wordAndSynonyms)
            {
                Console.Write($"{item.Key} - ");
                Console.WriteLine(string.Join(", ", item.Value));
            }
        }
    }
}
