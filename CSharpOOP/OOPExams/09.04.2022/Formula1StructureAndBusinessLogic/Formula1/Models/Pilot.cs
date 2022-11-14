using Formula1.Models.Contracts;
using System;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private bool canRace;
        private IFormulaOneCar car;
        private int numberOfWins;

        public Pilot(string fullName)
        {
            this.FullName = fullName;
            this.CanRace = false;
            this.NumberOfWins = 0;
            this.car = null;
        }

        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid pilot name: {value}.");
                }

                this.fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get => this.car;
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException($"Pilot car can not be null.");
                }

                this.car = value;
            }
        }

        public int NumberOfWins
        {
            get => this.numberOfWins;
            private set => this.numberOfWins = value;
        }

        public bool CanRace
        {
            get => this.canRace;
            private set => this.canRace = value;
        }

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins += 1;
        }

        public override string ToString()
        {
            return $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
        }
    }
}
