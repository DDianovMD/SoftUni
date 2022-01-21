using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullNamePattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";

            Regex regex = new Regex(fullNamePattern);

            string userInput = Console.ReadLine();

            Console.WriteLine(string.Join(" ", regex.Matches(userInput)));
        }
    }
}
