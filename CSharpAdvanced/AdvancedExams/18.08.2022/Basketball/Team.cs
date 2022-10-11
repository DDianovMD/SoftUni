using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players = new List<Player>();
        private string name;
        private int openPositions;
        private char group;

        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int OpenPositions { get => this.openPositions; set => this.openPositions = value; }
        public char Group { get => this.group; set => this.group = value; }
        public int Count { get => this.players.Count; }

        public string AddPlayer(Player player)
        {
            if (player.Name == null || player.Position == null || player.Name == String.Empty || player.Position == String.Empty)
            {
                return "Invalid player's information.";
            }

            if (OpenPositions == 0)
            {
                return "There are no more open positions.";
            }

            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            this.players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            int removedPlayers = this.players.RemoveAll(x => x.Name == name);
            bool result = false;

            if (removedPlayers > 0)
            {
                OpenPositions++;
                return result = true;
            }

            return result;
        }

        public int RemovePlayerByPosition(string position)
        {
            int removedPlayers = this.players.RemoveAll(x => x.Position == position);

            for (int i = 0; i < removedPlayers; i++)
            {
                OpenPositions++;
            }

            return removedPlayers;
        }

        public Player RetirePlayer(string name)
        {
            if (this.players.Any(x => x.Name == name))
            {
                foreach (var player in this.players)
                {
                    if (player.Name == name)
                    {
                        player.Retired = true;
                        return player;
                    }
                }
            }

            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            return this.players.Where(x => x.Games >= games).ToList();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Active players competing for Team {Name} from Group {Group}:");

            foreach (var player in this.players.Where(x => x.Retired == false))
            {
                result.AppendLine(player.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
