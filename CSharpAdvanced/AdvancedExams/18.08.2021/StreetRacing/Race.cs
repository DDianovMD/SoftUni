using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        private List<Car> Participants = new List<Car>();

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get => this.Participants.Count; }

        public void Add(Car car)
        {
            if (this.Participants.Where(x => x.LicensePlate == car.LicensePlate).Count() == 0)
            {
                if (this.Count < this.Capacity && car.HorsePower <= this.MaxHorsePower)
                {
                    this.Participants.Add(car);
                }
            }
        }

        public bool Remove(string licensePlate)
        {
            int removedCarsCount = this.Participants.RemoveAll(car => car.LicensePlate == licensePlate);

            if (removedCarsCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Car FindParticipant(string licensePlate)
        {
            Car result = this.Participants.Where(car => car.LicensePlate == licensePlate).ElementAt(0);

            return result;
        }

        public Car GetMostPowerfulCar()
        {
            Car result = null;

            if (this.Count > 0)
            {
                result = this.Participants.ElementAt(0);

                for (int i = 1; i < this.Participants.Count; i++)
                {
                    if (result.HorsePower < this.Participants[i].HorsePower)
                    {
                        result = this.Participants[i];
                    }
                }
            }

            return result;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");
            foreach (Car car in this.Participants)
            {
                result.AppendLine(car.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
