using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumberPattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            Regex regex = new Regex(phoneNumberPattern);

            string phones = Console.ReadLine();

            Console.WriteLine(string.Join(", ", regex.Matches(phones)));
        }
    }
}