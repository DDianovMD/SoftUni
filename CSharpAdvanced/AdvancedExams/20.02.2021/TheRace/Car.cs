using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Car
    {
        private string name;
        private int speed;

        public Car(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Speed { get => this.speed; set => this.speed = value; }
    }
}
