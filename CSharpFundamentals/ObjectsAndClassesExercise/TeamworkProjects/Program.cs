using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    public class Team
    {
        public string teamName { get; set; }
        public string creator { get; set; }
        public List<string> members { get; set; }

        public Team(string creator, string teamName)
        {
            this.creator = creator;
            this.teamName = teamName;
            this.members = new List<string>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Receive from user teams count:
            int teamsCount = int.Parse(Console.ReadLine());

            // Create list to save every team members:
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                // Read user input with team creator (with index [0]) and team name (with index [1]):
                string[] creatorAndTeamName = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                // Create object with user's input data:
                Team currentTeam = new Team(creatorAndTeamName[0], creatorAndTeamName[1]);

                // Use for unique creator and team name validation.
                bool userAndTeamNameAreUnique = true;

                // Check if given user has already created a team or team with given name is already created.
                foreach (var team in teams)
                {
                    if (team.teamName == creatorAndTeamName[1])
                    {
                        Console.WriteLine($"Team {team.teamName} was already created!");
                        userAndTeamNameAreUnique = false;
                    }

                    if (team.creator == creatorAndTeamName[0])
                    {
                        Console.WriteLine($"{team.creator} cannot create another team!");
                        userAndTeamNameAreUnique = false;
                    }
                }

                // Add created object if given user is not a creator of a team and team with such name doesn't exist already:
                if (userAndTeamNameAreUnique)
                {
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {creatorAndTeamName[1]} has been created by {creatorAndTeamName[0]}!");
                }
            }

            // Receive user's name (with index [0]) and team's name (with index [1]) where he wants to join in.
            string[] userToJoinTeam = Console.ReadLine()
                    .Split("->")
                    .ToArray();

            while (userToJoinTeam[0].ToLower() != "end of assignment")
            {
                // Use for validation that team exists and user is not already in a team.
                bool teamExists = true;
                bool userIsAlreadyAMember = false;

                // Check if team exists
                foreach (var team in teams)
                {
                    if (userToJoinTeam[1] != team.teamName)
                    {
                        teamExists = false;
                    }
                    else
                    {
                        teamExists = true;
                        break;
                    }
                }

                // If team doesn't exist:
                if (teamExists == false)
                {
                    Console.WriteLine($"Team {userToJoinTeam[1]} does not exist!");
                    teamExists = false;
                }
                // If team exists -> check if given user is a creator of a team or given user is already a member in the team.
                else
                {
                    foreach (var team in teams)
                    {
                        // If given user is a creator of a team.
                        if (userToJoinTeam[0] == team.creator)
                        {
                            Console.WriteLine($"Member {userToJoinTeam[0]} cannot join team {userToJoinTeam[1]}!");
                            userIsAlreadyAMember = true;
                            break;
                        }
                        // If given user is not a team creator -> check team members to see if he's already a member in the team.
                        else
                        {
                            if (team.members.Count > 0)
                            {
                                for (int i = 0; i < team.members.Count; i++)
                                {
                                    if (userToJoinTeam[0] == team.members[i])
                                    {
                                        Console.WriteLine($"Member {userToJoinTeam[0]} cannot join team {userToJoinTeam[1]}!");
                                        userIsAlreadyAMember = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                // Add given user in a team if he's not forbidden:
                if (teamExists == true && userIsAlreadyAMember == false)
                {
                    foreach (var team in teams)
                    {
                        if (userToJoinTeam[1] == team.teamName)
                        {
                            team.members.Add(userToJoinTeam[0]);
                        }
                    }
                }

                // Read next user and team until command "end of assignment" is given.
                userToJoinTeam = Console.ReadLine()
                    .Split("->")
                    .ToArray();
            }

            // Print result:
            foreach (var team in teams.OrderByDescending(x => x.members.Count).ThenBy(x => x.teamName).ThenBy(x => x.members))
            {
                if (team.members.Count > 0)
                {
                    Console.WriteLine(team.teamName);
                    Console.WriteLine($"- {team.creator}");

                    foreach (var member in team.members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.OrderBy(x => x.teamName))
            {
                if (team.members.Count == 0)
                {
                    Console.WriteLine($"{team.teamName}");
                }
            }
        }
    }
}
