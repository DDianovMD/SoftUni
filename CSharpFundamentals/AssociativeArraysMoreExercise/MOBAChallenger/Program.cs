using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Key - player, Value - Dictionary<position, skill>

            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> playersTotalSkills = new Dictionary<string, int>();

            string inputLine = string.Empty;

            List<string> splittedInput = new List<string>();

            bool keepGoing = true;

            while (keepGoing)
            {
                inputLine = Console.ReadLine();

                if (inputLine.ToLower() == "season end")
                {
                    keepGoing = false;
                    break;
                }

                if (inputLine.Contains("->"))
                {
                    splittedInput = inputLine
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    if (players.ContainsKey(splittedInput[0]) == false) // check if given player doesn't exist
                    {
                        players.Add(splittedInput[0], new Dictionary<string, int> { { splittedInput[1], int.Parse(splittedInput[2]) } }); // add player with his position and skill
                        playersTotalSkills.Add(splittedInput[0], int.Parse(splittedInput[2])); // add player and his total skill points
                    }
                    else
                    {
                        if (players[splittedInput[0]].ContainsKey(splittedInput[1]) == false) // check if existing player doesn't have given position
                        {
                            players[splittedInput[0]].Add(splittedInput[1], int.Parse(splittedInput[2])); // add given position
                            playersTotalSkills[splittedInput[0]] += int.Parse(splittedInput[2]); // update player's total skill points
                        }
                        else
                        {
                            if (players[splittedInput[0]][splittedInput[1]] < int.Parse(splittedInput[2])) // check if player at given position has lower skill value than given skill value
                            {
                                playersTotalSkills[splittedInput[0]] -= players[splittedInput[0]][splittedInput[1]];
                                playersTotalSkills[splittedInput[0]] += int.Parse(splittedInput[2]); // update player's total skill points

                                players[splittedInput[0]][splittedInput[1]] = int.Parse(splittedInput[2]); // update skill value
                            }
                        }
                    }
                }
                else if (inputLine.Contains("vs"))
                {
                    splittedInput = inputLine
                        .Split(" vs ", StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    if (players.ContainsKey(splittedInput[0]) && players.ContainsKey(splittedInput[1]))
                    {
                        for (int i = 0; i < players[splittedInput[0]].Count; i++)
                        {
                            if (players[splittedInput[1]].ContainsKey(players[splittedInput[0]].Keys.ElementAt(i)))
                            {
                                string currentKey = players[splittedInput[0]].Keys.ElementAt(i);

                                if (players[splittedInput[0]][currentKey] > players[splittedInput[1]][currentKey])
                                {
                                    players.Remove(splittedInput[1]);
                                    playersTotalSkills.Remove(splittedInput[1]);
                                    break;
                                }
                                else if (players[splittedInput[0]][currentKey] < players[splittedInput[1]][currentKey])
                                {
                                    players.Remove(splittedInput[0]);
                                    playersTotalSkills.Remove(splittedInput[0]);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            // Print result

            foreach (var player in playersTotalSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");

                for (int i = 0; i < players[player.Key].Count; i++)
                {
                    Console.WriteLine($"- {players[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Key} <::> {players[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Value}");
                }
            }
        }
    }
}
