using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Linq;
using System.Text;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private PlanetRepository planets;

        public Controller()
        {
            this.planets = new PlanetRepository();
        }

        public string CreatePlanet(string name, double budget)
        {
            IPlanet planet = new Planet(name, budget);

            if (this.planets.FindByName(name) != null)
            {
                return string.Format(OutputMessages.ExistingPlanet, name);
            }
            else
            {
                this.planets.AddItem(planet);

                return string.Format(OutputMessages.NewPlanet, name);
            }
        }

        public string AddUnit(string unitTypeName, string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (unitTypeName != nameof(AnonymousImpactUnit) &&
                unitTypeName != nameof(SpaceForces) &&
                unitTypeName != nameof(StormTroopers))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.ItemNotAvailable, unitTypeName));
            }
            else if (planet.Army.Any(x => x.GetType().Name == unitTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnitAlreadyAdded, unitTypeName, planetName));
            }
            else
            {
                IMilitaryUnit unit;

                if (unitTypeName == nameof(AnonymousImpactUnit))
                {
                    unit = new AnonymousImpactUnit();
                }
                else if (unitTypeName == nameof(SpaceForces))
                {
                    unit = new SpaceForces();
                }
                else
                {
                    unit = new StormTroopers();
                }

                planet.Spend(unit.Cost);
                planet.AddUnit(unit);

                return String.Format(OutputMessages.UnitAdded, unitTypeName, planetName);
            }
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (weaponTypeName != nameof(BioChemicalWeapon) &&
                weaponTypeName != nameof(NuclearWeapon) &&
                weaponTypeName != nameof(SpaceMissiles))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.ItemNotAvailable, weaponTypeName));
            }
            else if (planet.Weapons.Any(x => x.GetType().Name == weaponTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.WeaponAlreadyAdded, weaponTypeName, planetName));
            }
            else
            {
                IWeapon weapon;

                if (weaponTypeName == nameof(BioChemicalWeapon))
                {
                    weapon = new BioChemicalWeapon(destructionLevel);
                }
                else if (weaponTypeName == nameof(NuclearWeapon))
                {
                    weapon = new NuclearWeapon(destructionLevel);
                }
                else
                {
                    weapon = new SpaceMissiles(destructionLevel);
                }

                planet.Spend(weapon.Price);
                planet.AddWeapon(weapon);

                return String.Format(OutputMessages.WeaponAdded, planetName, weaponTypeName);
            }
        }

        public string SpecializeForces(string planetName)
        {
            IPlanet planet = this.planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (planet.Army.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NoUnitsFound);
            }

            planet.TrainArmy();
            planet.Spend(1.25d);

            return String.Format(OutputMessages.ForcesUpgraded, planetName);
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            IPlanet firstPlanet = this.planets.FindByName(planetOne);
            IPlanet secondPlanet = this.planets.FindByName(planetTwo);
            IPlanet winner = null;
            IPlanet loser = null;

            bool firstPlanetHasNuclearWeapon = firstPlanet.Weapons.Any(x => x.GetType().Name == nameof(NuclearWeapon));
            bool secondPlanetHasNuclearWeapon = secondPlanet.Weapons.Any(x => x.GetType().Name == nameof(NuclearWeapon));

            if (firstPlanet.MilitaryPower > secondPlanet.MilitaryPower)
            {
                winner = firstPlanet;
                loser = secondPlanet;
            }
            else if (firstPlanet.MilitaryPower < secondPlanet.MilitaryPower)
            {
                winner = secondPlanet;
                loser = firstPlanet;
            }
            else if (firstPlanet.MilitaryPower == secondPlanet.MilitaryPower)
            {
                if (firstPlanetHasNuclearWeapon == true && secondPlanetHasNuclearWeapon == false)
                {
                    winner = firstPlanet;
                    loser = secondPlanet;
                }
                else if (firstPlanetHasNuclearWeapon == false && secondPlanetHasNuclearWeapon == true)
                {
                    winner = secondPlanet;
                    loser = firstPlanet;
                }
                else
                {
                    firstPlanet.Spend(firstPlanet.Budget / 2);
                    secondPlanet.Spend(secondPlanet.Budget / 2);
                    return OutputMessages.NoWinner;
                }
            }

            if (winner.Name == firstPlanet.Name)
            {
                firstPlanet.Spend(firstPlanet.Budget / 2);
                firstPlanet.Profit(secondPlanet.Budget / 2);
                firstPlanet.Profit(secondPlanet.Army.Sum(x => x.Cost));
                firstPlanet.Profit(secondPlanet.Weapons.Sum(x => x.Price));
            }
            else
            {
                secondPlanet.Spend(secondPlanet.Budget / 2);
                secondPlanet.Profit(firstPlanet.Budget / 2);
                secondPlanet.Profit(firstPlanet.Army.Sum(x => x.Cost));
                secondPlanet.Profit(firstPlanet.Weapons.Sum(x => x.Price));
            }

            this.planets.RemoveItem(loser.Name);

            return String.Format(OutputMessages.WinnigTheWar, winner.Name, loser.Name);
        }


        public string ForcesReport()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("***UNIVERSE PLANET MILITARY REPORT***");

            foreach (IPlanet planet in this.planets.Models.OrderByDescending(x => x.MilitaryPower)
                                                          .ThenBy(x => x.Name))
            {
                result.AppendLine(planet.PlanetInfo());
            }

            return result.ToString().TrimEnd();
        }



    }
}