using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string[] userInput = Console.ReadLine().Split(";");

                if (userInput[0].ToUpper() == "END")
                {
                    break;
                }
                else if (userInput[0] == "Team")
                {
                    Team currentTeam = new Team(userInput[1]);
                    teams.Add(currentTeam);
                }
                else if (userInput[0] == "Add")
                {
                    bool teamExists = false;

                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].Name == userInput[1])
                        {
                            teamExists = true;

                            try
                            {
                                Player currentPlayer = new Player(userInput[2],
                                                int.Parse(userInput[3]),
                                                int.Parse(userInput[4]),
                                                int.Parse(userInput[5]),
                                                int.Parse(userInput[6]),
                                                int.Parse(userInput[7]));

                                teams[i].AddPlayer(currentPlayer);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                    }

                    if (teamExists == false)
                    {
                        Console.WriteLine($"Team {userInput[1]} does not exist.");
                    }
                }
                else if (userInput[0] == "Remove")
                {
                    bool playerExists = false;

                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].Name == userInput[1])
                        {
                            playerExists = true;

                            teams[i].RemovePlayer(userInput[2]);
                        }
                    }

                    if (playerExists == false)
                    {
                        Console.WriteLine($"Player {userInput[2]} is not in {userInput[1]} team.");
                    }
                }
                else if (userInput[0] == "Rating")
                {
                    bool teamExists = false;

                    foreach (var team in teams)
                    {
                        if (team.Name == userInput[1])
                        {
                            teamExists = true;
                            Console.WriteLine($"{team.Name} - {team.Rating}");
                        }
                    }

                    if (teamExists == false)
                    {
                        Console.WriteLine($"Team {userInput[1]} does not exist.");
                    }
                }
            }
        }
    }
}
