using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;
        private ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            this.pilots = new List<IPilot>();
            this.TookPlace = false;
        }

        public string RaceName
        {
            get => this.raceName;
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid race name: {value}.");
                }

                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get => this.numberOfLaps;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Invalid lap numbers: {value}.");
                }

                this.numberOfLaps = value;
            }
        }

        public bool TookPlace
        {
            get => this.tookPlace;
            set => this.tookPlace = value;
        }

        public ICollection<IPilot> Pilots => this.pilots;

        public void AddPilot(IPilot pilot)
        {
            this.Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"The {this.RaceName} race has:");
            info.AppendLine($"Participants: {this.Pilots.Count}");
            info.AppendLine($"Number of laps: {this.NumberOfLaps}");
            if (this.TookPlace)
            {
                info.AppendLine($"Took place: Yes");
            }
            else
            {
                info.AppendLine($"Took place: No");
            }

            return info.ToString().TrimEnd();
        }
    }
}
