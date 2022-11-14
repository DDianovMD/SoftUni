using Heroes.Core.Contracts;
using Heroes.Models.Contracts;
using Heroes.Models.Heroes;
using Heroes.Models.Map;
using Heroes.Models.Weapons;
using Heroes.Repositories;
using System;
using System.Linq;
using System.Text;

namespace Heroes.Core
{
    public class Controller : IController
    {
        private HeroRepository heroes;
        private WeaponRepository weapons;

        public Controller()
        {
            heroes = new HeroRepository();
            weapons = new WeaponRepository();
        }
        public string AddWeaponToHero(string weaponName, string heroName)
        {
            IHero hero = heroes.FindByName(heroName);
            IWeapon weapon = weapons.FindByName(weaponName);

            if (hero == null)
            {
                throw new InvalidOperationException($"Hero {heroName} does not exist.");
            }

            if (weapon == null)
            {
                throw new InvalidOperationException($"Weapon {weaponName} does not exist.");
            }

            if (hero.Weapon != null)
            {
                throw new InvalidOperationException($"Hero {heroName} is well-armed.");
            }

            hero.AddWeapon(weapon);
            weapons.Remove(weapon);

            return $"Hero {heroName} can participate in battle using a {hero.Weapon.GetType().Name.ToLower()}.";
        }

        public string CreateHero(string type, string name, int health, int armour)
        {
            if (heroes.FindByName(name) != null)
            {
                throw new InvalidOperationException($"The hero {name} already exists.");
            }

            IHero hero;

            if (type == "Barbarian")
            {
                hero = new Barbarian(name, health, armour);
                heroes.Add(hero);
                return $"Successfully added Barbarian {name} to the collection.";
            }
            else if (type == "Knight")
            {
                hero = new Knight(name, health, armour);
                heroes.Add(hero);
                return $"Successfully added Sir {name} to the collection.";
            }
            else
            {
                throw new InvalidOperationException("Invalid hero type.");
            }
        }

        public string CreateWeapon(string type, string name, int durability)
        {
            if (weapons.FindByName(name) != null)
            {
                throw new InvalidOperationException($"The weapon {name} already exists.");
            }

            IWeapon weapon;

            if (type == "Claymore")
            {
                weapon = new Claymore(name, durability);
                weapons.Add(weapon);
            }
            else if (type == "Mace")
            {
                weapon = new Mace(name, durability);
                weapons.Add(weapon);
            }
            else
            {
                throw new InvalidOperationException("Invalid weapon type.");
            }

            return $"A {type.ToLower()} {name} is added to the collection.";
        }

        public string HeroReport()
        {
            StringBuilder report = new StringBuilder();

            foreach (var hero in heroes.Models.OrderBy(hero => hero.GetType().Name)
                                              .ThenByDescending(hero => hero.Health)
                                              .ThenBy(hero => hero.Name))
            {
                report.AppendLine($"{hero.GetType().Name}: {hero.Name}");
                report.AppendLine($"--Health: {hero.Health}");
                report.AppendLine($"--Armour: {hero.Armour}");
                if (hero.Weapon != null)
                {
                    report.AppendLine($"--Weapon: {hero.Weapon.Name}");
                }
                else
                {
                    report.AppendLine("--Weapon: Unarmed");
                }
            }

            return report.ToString().TrimEnd();
        }

        public string StartBattle()
        {
            Map map = new Map();
            var aliveHeroes = heroes.Models.Where(hero => hero.IsAlive && hero.Weapon != null).ToList();

            return map.Fight(aliveHeroes);
        }
    }
}