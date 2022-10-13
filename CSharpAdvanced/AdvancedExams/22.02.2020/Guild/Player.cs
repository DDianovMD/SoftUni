using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        private string name;
        private string @class;
        private string rank = "Trial";
        private string description = "n/a";

        public Player(string name, string @class)
        {
            this.Name = name;
            this.Class = @class;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Class { get => this.@class; set => this.@class = value; }
        public string Rank { get => this.rank; set => this.rank = value; }
        public string Description { get => this.description; set => this.description = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Player {this.Name}: {this.Class}");
            result.AppendLine($"Rank: {this.Rank}");
            result.AppendLine($"Description: {this.Description}");

            return result.ToString().Trim();
        }
    }
}
