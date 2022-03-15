using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public Dictionary<string, Dictionary<double, int>> Tires { get; set; }

        public Car(string model,
                   int engineSpeed, int enginePower,
                   int cargoWeight, string cargoType,
                   double tire1pressure, int tire1age,
                   double tire2pressure, int tire2age,
                   double tire3pressure, int tire3age,
                   double tire4pressure, int tire4age)
        {
            this.Model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoType, cargoWeight);
            this.Tires = new Dictionary<string, Dictionary<double, int>>()
            {
                ["tire1"] = new Dictionary<double, int> { [tire1pressure] = tire1age },
                ["tire2"] = new Dictionary<double, int> { [tire2pressure] = tire2age },
                ["tire3"] = new Dictionary<double, int> { [tire3pressure] = tire3age },
                ["tire4"] = new Dictionary<double, int> { [tire4pressure] = tire4age },

            };
        }

    }
}
