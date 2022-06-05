using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersConsumptionPerKm = litersPerKm + 1.6;
        }

        public override void Drive(double distance)
        {
            double neededFuel = distance * this.LitersConsumptionPerKm;

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
    }
}
