using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userInput = new List<string>();
            Dictionary<string, string> contests = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> candidatesTotalScore = new Dictionary<string, int>();

            bool keepGoing = true;

            while (keepGoing)
            {
                userInput = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (userInput[0].ToLower() == "end of contests")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    if (contests.ContainsKey(userInput[0]) == false) // check if contest is already existing and add it if not.
                    {
                        contests.Add(userInput[0], userInput[1]);
                    }                    
                }

                userInput.Clear();
            }

            keepGoing = true;

            while (keepGoing)
            {
                userInput = Console.ReadLine()
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (userInput[0].ToLower() == "end of submissions")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    if (contests.ContainsKey(userInput[0])) // check if there is such contest
                    {
                        if (contests[userInput[0]] == userInput[1]) // check if candidate has valid password for the contest
                        {
                            if (candidates.ContainsKey(userInput[2])) // check if candidate already participated in any contests
                            {
                                if (candidates[userInput[2]].ContainsKey(userInput[0])) // check if candidate has already participated in the exact contest
                                {
                                    if (candidates[userInput[2]][userInput[0]] < int.Parse(userInput[3])) // check if previous candidate's points are lower then current result
                                    {
                                        candidates[userInput[2]][userInput[0]] = int.Parse(userInput[3]); // update candidate's result
                                    }
                                }
                                else // if candidate hasn't participated in the exact contest
                                {
                                    candidates[userInput[2]].Add(userInput[0], int.Parse(userInput[3])); // add contest and candidate's result
                                }
                                
                            }
                            else // if candidate hasn't participated in any contests yet
                            {
                                candidates.Add(userInput[2], new Dictionary<string, int>()); // add candidate
                                candidates[userInput[2]].Add(userInput[0], int.Parse(userInput[3])); // add contest and candidate's result
                            }
                        }
                    }
                }

                userInput.Clear();
            }

            // Get each candidate total score
            foreach (var candidate in candidates)
            {
                candidatesTotalScore.Add(candidate.Key, candidate.Value.Sum(x => x.Value));
            }

            // Print result
            Console.WriteLine($"Best candidate is {candidatesTotalScore.OrderByDescending(x => x.Value).ElementAt(0).Key} with total {candidatesTotalScore.OrderByDescending(x => x.Value).ElementAt(0).Value} points.");
            Console.WriteLine("Ranking: ");
            foreach (var candidate in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);
                for (int i = 0; i < candidate.Value.Count; i++)
                {
                    Console.WriteLine($"#  {candidate.Value.OrderByDescending(x => x.Value).ElementAt(i).Key} -> {candidate.Value.OrderByDescending(x => x.Value).ElementAt(i).Value}");
                }                
            }
        }
    }
}
