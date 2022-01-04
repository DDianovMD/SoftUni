using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string replaceString = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    replaceString += "*";
                }

                while (text.IndexOf(word) != -1)
                {
                    text = text.Replace(word, replaceString);
                }
            }

            Console.WriteLine(text);
        }
    }
}
