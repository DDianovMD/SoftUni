using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private List<Player> players;
        private int rating;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public List<Player> Players
        {
            get => players;
        }
        public string Name { get; set; }
        public int Rating
        {
            get
            {
                double ratingsSum = 0;

                foreach (var player in players)
                {
                    ratingsSum += player.CalculateSkillLevel();
                }

                return rating = (int)Math.Round(ratingsSum);
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            bool playerExists = false;

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == playerName)
                {
                    playerExists = true;
                    players.RemoveAt(i);
                }
            }
                            
            if (playerExists == false)
            {
                Console.WriteLine($"Player {playerName} is not in {this.Name} team.");
            }
        }
    }
}
