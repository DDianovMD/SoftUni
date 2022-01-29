using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string emailPattern = @"[\w\-_\.]+@[a-zA-Z\-]+\.[a-zA-Z.\-]+\b";

            MatchCollection emails = Regex.Matches(input, emailPattern);

            foreach (var email in emails)
            {
                if (email.ToString()[0] != '.' && email.ToString()[0] != '-' && email.ToString()[0] != '_')
                {
                    Console.WriteLine(email.ToString());
                }
            }
        }
    }
}
