using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string separatorPattern = @"\s*,+\s+";
            string jackpotPattern = @"(?<jackpot>\@{10}|\#{10}|\${10}|\^{10})";
            string winningPattern = @"(?<nonJackpot>\@{6,9}|\#{6,9}|\${6,9}|\^{6,9})";

            string userInput = Console.ReadLine();
            string[] tickets = Regex.Split(userInput, separatorPattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10, 10);

                    if (Regex.IsMatch(firstHalf, jackpotPattern) && Regex.IsMatch(secondHalf, jackpotPattern))
                    {
                        int length = Math.Min(Regex.Match(firstHalf, jackpotPattern).Value.Length, Regex.Match(secondHalf, jackpotPattern).Value.Length);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{Regex.Match(firstHalf, jackpotPattern).Value.ElementAt(0)} Jackpot!");
                    }
                    else if (Regex.IsMatch(firstHalf, winningPattern) && Regex.IsMatch(secondHalf, winningPattern))
                    {
                        int length = Math.Min(Regex.Match(firstHalf, winningPattern).Value.Length, Regex.Match(secondHalf, winningPattern).Value.Length);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{Regex.Match(firstHalf, winningPattern).Value.ElementAt(0)}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
