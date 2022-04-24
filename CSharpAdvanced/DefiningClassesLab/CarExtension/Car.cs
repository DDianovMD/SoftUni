using System;

namespace Car
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get => this.make; set => this.make = value; }
        public string Model { get => this.model; set => this.model = value; }
        public int Year { get => this.year; set => this.year = value; }
        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        public void Drive(double distance)
        {
            if (this.fuelQuantity - this.fuelConsumption * distance >= 0)
            {
                this.fuelQuantity = this.fuelConsumption * distance;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string make = this.make;
            string model = this.model;
            string year = this.year.ToString();
            string fuel = $"{this.fuelQuantity:F2}";

            return  make + Environment.NewLine +
                    model + Environment.NewLine + 
                    year + Environment.NewLine + 
                    fuel;
        }
    }
}
