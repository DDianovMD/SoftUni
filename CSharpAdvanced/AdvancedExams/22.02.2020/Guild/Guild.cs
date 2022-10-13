using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> roster;
        private string name;
        private int capacity;

        public Guild(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.roster = new List<Player>();
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int Count { get => this.roster.Count; }

        public void AddPlayer(Player player)
        {
            if (this.Count < this.Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            int removedPLayersCount = roster.RemoveAll(player => player.Name == name);
            return removedPLayersCount > 0;

            // Another implementation

            //for (int i = 0; i < this.roster.Count; i++)
            //{
            //    if (roster[i].Name == name)
            //    {
            //        this.roster.Remove(roster[i]);
            //        return true;
            //    }
            //}

            //return false;
        }

        public void PromotePlayer(string name)
        {
            roster.Where(player => player.Name == name).ElementAt(0).Rank = "Member";
        }

        public void DemotePlayer(string name)
        {
            roster.Where(player => player.Name == name).ElementAt(0).Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> result = new List<Player>();

            for (int i = 0; i < roster.Count; i++)
            {
                if (roster[i].Class == @class)
                {
                    result.Add(roster[i]);
                    roster.Remove(roster[i]);
                    i--;
                }
            }

            return result.ToArray();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player in roster)
            {
                result.AppendLine(player.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
