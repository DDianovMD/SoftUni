using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            // key - string username; value - int points
            Dictionary<string, int> results = new Dictionary<string, int>();

            // key - string language; value - int submissionsCount
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string[] userInput = Console.ReadLine()
                                            .Split("-", StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                if (userInput[0].ToLower() == "exam finished")
                {
                    break;
                }

                string username = userInput[0];

                if (userInput[1].ToLower() == "banned")
                {
                    results.Remove(username);
                }
                else
                {
                    string language = userInput[1];
                    int points = int.Parse(userInput[2]);

                    if (results.ContainsKey(username) == false)
                    {
                        results.Add(username, points);
                    }
                    else
                    {
                        if (results[username] < points)
                        {
                            results[username] = points;
                        }
                    }

                    if (submissions.ContainsKey(language) == false)
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language]++;
                    }
                }
            }

            // Print results
            Console.WriteLine("Results:");

            foreach (var kvp in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
