using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public List<Racer> data = new List<Racer>();
        private string name;
        private int capacity;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int Count { get => this.data.Count; }

        public void Add(Racer Racer)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racerToRemove = this.data.FirstOrDefault(racer => racer.Name == name);

            return this.data.Remove(racerToRemove);
        }

        public Racer GetOldestRacer()
        {
            return this.data.OrderByDescending(racer => racer.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            return this.data.FirstOrDefault(racer => racer.Name == name);
        }

        public Racer GetFastestRacer()
        {
            return this.data.OrderByDescending(racer => racer.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Racers participating at {this.Name}:");
            foreach (Racer racer in this.data)
            {
                result.AppendLine(racer.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
