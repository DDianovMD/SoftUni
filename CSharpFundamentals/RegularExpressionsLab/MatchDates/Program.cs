using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string datesPattern = @"\b(?<day>0[1-9]|[1-2][0-9]|3[0-2])(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string userInput = Console.ReadLine();

            MatchCollection matches = Regex.Matches(userInput, datesPattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
