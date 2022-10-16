using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    public class Program
    {
        public static void Main()
        {
            // Input info
            char[] vowelsInfo = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .Select(char.Parse)
                                             .ToArray();

            char[] consonantsInputInfo = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(char.Parse)
                                                .ToArray();

            List<string> words = new List<string>();
            words.Add("pear");
            words.Add("flour");
            words.Add("pork");
            words.Add("olive");

            // Used variables
            Queue<char> vowels = new Queue<char>(vowelsInfo);
            Stack<char> consonants = new Stack<char>(consonantsInputInfo);
            List<char> collectedLetters = new List<char>();
            List<string> completedWords = new List<string>();

            while (consonants.Count > 0)
            {
                char currentVowel = vowels.Dequeue();

                foreach (string word in words)
                {
                    if (word.Contains(currentVowel))
                    {
                        collectedLetters.Add(currentVowel);
                        break;
                    }
                }

                vowels.Enqueue(currentVowel);

                char currentConsonant = consonants.Pop();

                foreach (string word in words)
                {
                    if (word.Contains(currentConsonant))
                    {
                        collectedLetters.Add(currentConsonant);
                        break;
                    }
                }
            }

            foreach (string word in words)
            {
                bool isCompleted = true;

                foreach (char character in word)
                {
                    if (collectedLetters.Contains(character) == false)
                    {
                        isCompleted = false;
                        break;
                    }
                }

                if (isCompleted)
                {
                    completedWords.Add(word);
                }
            }

            // Print output
            Console.WriteLine($"Words found: {completedWords.Count}");
            foreach (string word in completedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
