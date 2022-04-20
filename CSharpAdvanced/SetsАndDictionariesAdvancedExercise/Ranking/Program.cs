using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main()
        {
            // key - contest name; value - password for contest
            Dictionary<string, string> contests = new Dictionary<string, string>();

            // key - contender name; value - dictionary<contest name, result>
            Dictionary<string, Dictionary<string, int>> contenders = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] userInput = Console.ReadLine()
                                            .Split(":", StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                if (userInput[0].ToLower() == "end of contests")
                {
                    break;
                }

                string contest = userInput[0];
                string password = userInput[1];

                contests[contest] = password;
            }

            while (true)
            {
                string[] userInput = Console.ReadLine()
                                            .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                if (userInput[0].ToLower() == "end of submissions")
                {
                    break;
                }

                string contest = userInput[0];
                string password = userInput[1];
                string username = userInput[2];
                int points = int.Parse(userInput[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (contenders.ContainsKey(username) == false)
                    {
                        contenders.Add(username, new Dictionary<string, int>());

                        if (contenders[username].ContainsKey(contest) == false)
                        {
                            contenders[username].Add(contest, points);
                        }
                        else
                        {
                            if (contenders[username][contest] < points)
                            {
                                contenders[username][contest] = points;
                            }
                        }
                    }
                    else
                    {
                        if (contenders[username].ContainsKey(contest) == false)
                        {
                            contenders[username].Add(contest, points);
                        }
                        else
                        {
                            if (contenders[username][contest] < points)
                            {
                                contenders[username][contest] = points;
                            }
                        }
                    }
                }
            }

            string bestCandidate = string.Empty;
            int bestResult = 0;

            // Calculate each candidate total points and find the best one
            foreach (var candidate in contenders)
            {
                int result = 0;

                foreach (var kvp in candidate.Value)
                {
                    result += kvp.Value;
                }

                if (result > bestResult)
                {
                    bestResult = result;
                    bestCandidate = candidate.Key;
                }
            }

            // Print results;
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestResult} points.");
            Console.WriteLine("Ranking:");

            foreach (var candidate in contenders.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);

                foreach (var kvp in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
