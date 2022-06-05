using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double tankCapacity;
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double litersConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            LitersConsumptionPerKm = litersConsumptionPerKm;
        }

        protected Vehicle(double fuelQuantity, double litersConsumptionPerKm, double tankCapacity)
        {
            LitersConsumptionPerKm = litersConsumptionPerKm;
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity
        {
            get => fuelQuantity; 
            
            set
            {
                if (value <= this.TankCapacity)
                {
                    fuelQuantity = value;
                }
                else
                {
                    fuelQuantity = 0;
                }
            }
        }
        public double LitersConsumptionPerKm { get; set; }
        public double TankCapacity { get; set; }

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);

    }
}
