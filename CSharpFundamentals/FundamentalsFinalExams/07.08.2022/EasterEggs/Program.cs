using System;
using System.Text.RegularExpressions;

namespace EasterEggs
{
    internal class Program
    {
        static void Main()
        {
            string userInput = Console.ReadLine();

            string pattern = @"[@#](?<color>[a-z]{3,})[@#][^a-zA-Z\d]*\/(?<quantity>\d+)\/*";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(userInput);

            // Pritn output
            foreach (Match match in matches)
            {
                Console.WriteLine($"You found {match.Groups["quantity"]} {match.Groups["color"]} eggs!");
            }
        }
    }
}
