using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersConsumptionPerKm)
            : base(fuelQuantity, litersConsumptionPerKm) { }

        public Bus(double fuelQuantity, double litersConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, litersConsumptionPerKm, tankCapacity) { }

        public override void Drive(double distance)
        {
            double neededFuel = distance * (this.LitersConsumptionPerKm + 1.4);

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {
            double neededFuel = distance * this.LitersConsumptionPerKm;

            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (FuelQuantity + liters <= TankCapacity)
            {
                this.FuelQuantity += liters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
