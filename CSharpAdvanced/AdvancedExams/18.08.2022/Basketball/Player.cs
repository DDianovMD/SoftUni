using System;
using System.Text;

namespace Basketball
{
    public class Player
    {
        private string name;
        private string position;
        private double rating;
        private int games;
        private bool retired = false;

        public string Name { get => this.name; set => this.name = value; }
        public string Position { get => this.position; set => this.position = value; }
        public double Rating { get => this.rating; set => this.rating = value; }
        public int Games { get => this.games; set => this.games = value; }
        public bool Retired { get => this.retired; set => this.retired = value; }

        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"-Player: {Name}");
            result.AppendLine($"--Position: {Position}");
            result.AppendLine($"--Rating: {Rating}");
            result.AppendLine($"--Games played: {Games}");

            return result.ToString().Trim();
        }
    }
}
