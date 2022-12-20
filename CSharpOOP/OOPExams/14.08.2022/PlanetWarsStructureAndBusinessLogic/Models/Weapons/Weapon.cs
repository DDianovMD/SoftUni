using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Utilities.Messages;
using System;

namespace PlanetWars.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private double price;
        private int destructionLevel;

        public Weapon(int destructionLevel, double price)
        {
            this.Price = price;
            this.DestructionLevel = destructionLevel;
        }

        public double Price { get => this.price; private set => this.price = value; }

        public int DestructionLevel
        {
            get => this.destructionLevel;

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.TooLowDestructionLevel);
                }
                else if (value > 10)
                {
                    throw new ArgumentException(ExceptionMessages.TooHighDestructionLevel);
                }
                else
                {
                    this.destructionLevel = value;
                }
            }
        }
    }
}
