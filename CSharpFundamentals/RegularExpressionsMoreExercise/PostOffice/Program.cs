using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            string[] parts = userInput.Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // Whole RegEx pattern ->     ((#|\$|%|&){1}([A-Z]+)(\1)|(\d+)(?:\:)(\d{2})         

            string firstPartPattern = @"(#|\$|%|&){1}([A-Z]+)(\1)";
            string secondPartPattern = @"(\d+)(?:\:)(\d{2})";

            string firstPartMatch = Regex.Match(parts[0], firstPartPattern).ToString();
            List<string> secondPartMatches = Regex.Matches(parts[1], secondPartPattern).Select(x => x.ToString()).ToList();
            secondPartMatches = secondPartMatches.Distinct().ToList();

            foreach (var word in parts[2].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray())
            {
                foreach (var part in secondPartMatches)
                {                    
                    if ((int)word[0] == int.Parse(part.Substring(0, 2)) && word.Length == int.Parse(part.Substring(3, 2)) + 1)
                    {
                        if (firstPartMatch.Contains(word[0]))
                        {
                            Console.WriteLine(word);
                        }
                    }
                }
            }
        }
    }
}
