using System;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelledDistance = 0;
        }

        public void Drive(double amountOfKm)
        {
            if (this.FuelAmount >= amountOfKm * this.FuelConsumptionPerKilometer)
            {
                this.FuelAmount -= amountOfKm * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}
