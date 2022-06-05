using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm + 1.6) { }

        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm + 1.6, tankCapacity) { }

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
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (FuelQuantity + liters * 0.95 <= TankCapacity)
            {
                this.FuelQuantity += liters * 0.95;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
