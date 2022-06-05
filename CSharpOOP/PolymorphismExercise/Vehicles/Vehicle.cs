using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double LitersConsumptionPerKm { get; set; }

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);

    }
}
