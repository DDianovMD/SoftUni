using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Fish = new List<Fish>();
        private string material;
        private int capacity;

        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
        }

        public string Material { get => this.material; set => this.material = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int Count { get => this.Fish.Count; }

        public string AddFish(Fish fish)
        {
            if (this.Count < this.Capacity)
            {
                if (fish.FishType != null && fish.FishType != " " && fish.Length > 0 && fish.Weight > 0)
                {
                    this.Fish.Add(fish);
                    return $"Successfully added {fish.FishType} to the fishing net.";
                }
                else
                {
                    return "Invalid fish.";
                }
            }
            else
            {
                return "Fishing net is full.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            int removedFishCount = this.Fish.RemoveAll(fish => fish.Weight == weight);

            return removedFishCount > 0;
        }

        public Fish GetFish(string fishType)
        {
            return this.Fish.Where(fish => fish.FishType == fishType).ElementAt(0);
        }

        public Fish GetBiggestFish()
        {
            return this.Fish.OrderByDescending(fish => fish.Length).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Into the {this.Material}:");
            foreach (Fish fish in this.Fish.OrderByDescending(fish => fish.Length))
            {
                result.AppendLine(fish.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
