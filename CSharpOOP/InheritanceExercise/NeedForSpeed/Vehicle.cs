using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        int horsePower;
        double fuel;
        double defaultFuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }

        public int HorsePower { get => this.horsePower; set => this.horsePower = value; }
        public double Fuel { get => this.fuel; set => this.fuel = value; }
        public double DefaultFuelConsumption { get => this.defaultFuelConsumption; set => this.defaultFuelConsumption = 1.25; }
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers)
        {
            if (FuelConsumption * kilometers <= Fuel)
            {
                Fuel -= FuelConsumption * kilometers;
            }            
        }
    }
}
