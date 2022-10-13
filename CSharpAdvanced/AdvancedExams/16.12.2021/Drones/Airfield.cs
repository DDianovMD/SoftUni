using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> drones = new List<Drone>();
        private string name;
        private int capacity;
        private double landingStrip;

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public double LandingStrip { get => this.landingStrip; set => this.landingStrip = value; }
        public int Count { get => this.drones.Count; }

        public string AddDrone(Drone drone)
        {
            if (this.Count < this.Capacity)
            {
                if (drone.Name != null &&
                    drone.Name != " " &&
                    drone.Brand != null &&
                    drone.Brand != " " &&
                    drone.Range > 5 &&
                    drone.Range < 15)
                {
                    this.drones.Add(drone);
                    return $"Successfully added {drone.Name} to the airfield.";
                }
                else
                {
                    return "Invalid drone.";
                }
            }
            else
            {
                return "Airfield is full.";
            }
        }

        public bool RemoveDrone(string name)
        {
            int removedDronesCount = this.drones.RemoveAll(drone => drone.Name == name);
            return removedDronesCount > 0;
        }

        public int RemoveDroneByBrand(string brand)
        {
            int removedDronesCount = this.drones.RemoveAll(drone => drone.Brand == brand);
            return removedDronesCount;
        }

        public Drone FlyDrone(string name)
        {
            Drone result = null;

            for (int i = 0; i < this.drones.Count; i++)
            {
                if (this.drones[i].Name == name)
                {
                    this.drones[i].Available = false;
                    result = this.drones[i];
                }
            }

            return result;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> result = new List<Drone>();

            foreach (Drone drone in this.drones)
            {
                if (drone.Range >= range)
                {
                    result.Add(FlyDrone(drone.Name));
                }
            }

            return result;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Drones available at {this.Name}:");
            foreach (Drone drone in this.drones.Where(drone => drone.Available == true))
            {
                result.AppendLine(drone.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
