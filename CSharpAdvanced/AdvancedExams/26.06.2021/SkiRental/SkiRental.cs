using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        private string name;
        private int capacity;

        public SkiRental(string name, int capacity)
        {
            this.data = new List<Ski>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int Count { get => this.data.Count; }

        public void Add(Ski ski)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Ski skiToRemove = null;

            foreach (Ski ski in this.data)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    skiToRemove = ski;
                    break;
                }
            }

            return this.data.Remove(skiToRemove);
        }

        public Ski GetNewestSki()
        {
            if (this.Count > 0)
            {
                Ski result = this.data.ElementAt(0);

                foreach (Ski ski in this.data)
                {
                    if (ski.Year > result.Year)
                    {
                        result = ski;
                    }
                }

                return result;
            }
            else
            {
                return null;
            }
        }

        public Ski GetSki(string manufacturer, string model)
        {
            Ski result = null;

            foreach (Ski ski in this.data)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    result = ski;
                    break;
                }
            }

            return result;
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"The skis stored in {this.Name}:");
            foreach (Ski ski in this.data)
            {
                result.AppendLine(ski.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
