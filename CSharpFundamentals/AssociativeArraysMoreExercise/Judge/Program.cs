using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> participantsTotalScore = new Dictionary<string, int>();

            string[] userInput = new string[3];

            bool keepGoing = true;

            while (keepGoing)
            {
                userInput = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (userInput[0].ToLower() == "no more time")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    if (contests.ContainsKey(userInput[1]) == false) // if current contest doesn't exist
                    {
                        contests.Add(userInput[1], new Dictionary<string, int>()); // add contest
                        contests[userInput[1]].Add(userInput[0], int.Parse(userInput[2])); // add user and score

                        // Track each participants total score
                        if (participantsTotalScore.ContainsKey(userInput[0]) == false)
                        {
                            participantsTotalScore.Add(userInput[0], int.Parse(userInput[2]));
                        }
                        else
                        {
                            participantsTotalScore[userInput[0]] += int.Parse(userInput[2]);
                        }
                    }
                    else // if contest exists
                    {
                        if (contests[userInput[1]].ContainsKey(userInput[0])) // if current user has already participated in the contest
                        {
                            if (contests[userInput[1]][userInput[0]] < int.Parse(userInput[2])) // check if user's previous score is lower than current score
                            {
                                // Track each participants total score
                                participantsTotalScore[userInput[0]] -= contests[userInput[1]][userInput[0]];
                                participantsTotalScore[userInput[0]] += int.Parse(userInput[2]);

                                contests[userInput[1]][userInput[0]] = int.Parse(userInput[2]); // replace user's score with best result
                            }
                        }
                        else // if current user hasn't participated in the contest
                        {
                            contests[userInput[1]].Add(userInput[0], int.Parse(userInput[2])); // add user and score

                            // Track each participants total score
                            if (participantsTotalScore.ContainsKey(userInput[0]) == false)
                            {
                                participantsTotalScore.Add(userInput[0], int.Parse(userInput[2]));
                            }
                            else
                            {
                                participantsTotalScore[userInput[0]] += int.Parse(userInput[2]);
                            }
                        }
                    }
                }
            }

            // Print result
            foreach (var kvp in contests)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Key} <::> {kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            int placement = 1;
            foreach (var kvp in participantsTotalScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {                
                Console.WriteLine($"{placement}. {kvp.Key} -> {kvp.Value}");
                placement++;
            }
        }
    }
}
