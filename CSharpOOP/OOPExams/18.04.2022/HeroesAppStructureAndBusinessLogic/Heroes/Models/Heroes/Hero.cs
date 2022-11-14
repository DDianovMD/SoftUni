using Heroes.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private bool isAlive;
        private IWeapon weapon;

        protected Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
            this.IsAlive = GetLivingStatus(health);
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Health
        {
            get => this.health;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }

                this.health = value;
            }
        }

        public int Armour
        {
            get => this.armour;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }

                this.armour = value;
            }
        }

        public IWeapon Weapon
        {
            get => this.weapon;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }

                this.weapon = value;
            }
        }

        public bool IsAlive
        {
            get => this.isAlive;
            private set
            {
                this.isAlive = value;
            }
        }

        public void AddWeapon(IWeapon weapon)
        {
            if (weapon != null)
            {
                this.Weapon = weapon;
            }
        }

        public void TakeDamage(int points)
        {
            if (this.Armour >= points)
            {
                this.Armour -= points;
            }
            else
            {
                if (Math.Abs(this.Armour - points) <= this.Health)
                {
                    this.Health -= Math.Abs(this.Armour - points);
                }
                else
                {
                    this.Health = 0;
                }

                this.Armour = 0;
            }

            this.IsAlive = GetLivingStatus(this.Health);
        }

        protected bool GetLivingStatus(int health)
        {
            return health > 0;
        }
    }
}
