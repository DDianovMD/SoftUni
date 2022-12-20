using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Utilities.Messages;
using System;

namespace PlanetWars.Models.MilitaryUnits
{
    public abstract class MilitaryUnit : IMilitaryUnit
    {
        private double cost;
        private int enduranceLevel;

        public MilitaryUnit(double cost)
        {
            this.Cost = cost;
            this.EnduranceLevel = 1;
        }

        public double Cost { get => this.cost; private set => this.cost = value; }

        public int EnduranceLevel { get => this.enduranceLevel; private set => this.enduranceLevel = value; }

        public virtual void IncreaseEndurance()
        {
            if (this.EnduranceLevel == 20)
            {
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }

            this.EnduranceLevel += 1;
        }
    }
}
