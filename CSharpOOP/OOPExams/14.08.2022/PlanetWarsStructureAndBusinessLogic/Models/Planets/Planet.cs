using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private double budget;
        private double militaryPower;
        private UnitRepository units;
        private WeaponRepository weapons;

        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
            this.units = new UnitRepository();
            this.weapons = new WeaponRepository();
            this.MilitaryPower = CalculateMilitaryPower(this.Army, this.Weapons);
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }

                this.name = value;
            }
        }

        public double Budget
        {
            get => this.budget;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);
                }

                this.budget = value;
            }
        }

        public double MilitaryPower
        {
            get => this.militaryPower;

            private set
            {
                if (this.Army.Any(x => x.GetType().Name == nameof(AnonymousImpactUnit)))
                {
                    value += value * 0.3;
                }

                if (this.Weapons.Any(x => x.GetType().Name == nameof(NuclearWeapon)))
                {
                    value += value * 0.45;
                }

                this.militaryPower = Math.Round(value, 3);
            }
        }

        public IReadOnlyCollection<IMilitaryUnit> Army => this.units.Models;

        public IReadOnlyCollection<IWeapon> Weapons => this.weapons.Models;

        private double CalculateMilitaryPower(IReadOnlyCollection<IMilitaryUnit> Army, IReadOnlyCollection<IWeapon> Weapons)
        {
            int endurancesSum = Army.Sum(x => x.EnduranceLevel);
            double destructionLevelsSum = Weapons.Sum(x => x.DestructionLevel);

            return endurancesSum + destructionLevelsSum;
        }

        public void AddUnit(IMilitaryUnit unit)
        {
            this.units.AddItem(unit);
            this.MilitaryPower = CalculateMilitaryPower(this.Army, this.Weapons);
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.AddItem(weapon);
            this.MilitaryPower = CalculateMilitaryPower(this.Army, this.Weapons);
        }

        public string PlanetInfo()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Planet: {this.Name}");
            result.AppendLine($"--Budget: {this.Budget} billion QUID");

            if (this.Army.Count > 0)
            {
                result.AppendLine($"--Forces: {string.Join(", ", this.Army.Select(x => x.GetType().Name))}");
            }
            else
            {
                result.AppendLine($"--Forces: No units");
            }

            if (this.Weapons.Count > 0)
            {
                result.AppendLine($"--Combat equipment: {string.Join(", ", this.Weapons.Select(x => x.GetType().Name))}");
            }
            else
            {
                result.AppendLine($"--Combat equipment: No weapons");
            }

            result.AppendLine($"--Military Power: {this.MilitaryPower}");

            return result.ToString().TrimEnd();
        }

        public void Profit(double amount)
        {
            this.Budget += amount;
        }

        public void Spend(double amount)
        {
            if (this.Budget < amount)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }

            this.Budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (IMilitaryUnit unit in this.Army)
            {
                unit.IncreaseEndurance();
            }

            this.MilitaryPower = CalculateMilitaryPower(this.Army, this.Weapons);
        }
    }
}
