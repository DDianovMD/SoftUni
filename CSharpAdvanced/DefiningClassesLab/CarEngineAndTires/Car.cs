using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make { get => this.make; set => this.make = value; }
        public string Model { get => this.model; set => this.model = value; }
        public int Year { get => this.year; set => this.year = value; }
        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Tire[] Tires { get => tires; set => tires = value; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            if (this.fuelQuantity - this.fuelConsumption * distance >= 0)
            {
                this.fuelQuantity = this.fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string make = this.make;
            string model = this.model;
            string year = this.year.ToString();
            string fuel = $"{this.fuelQuantity:F2}";

            return make + Environment.NewLine +
                    model + Environment.NewLine +
                    year + Environment.NewLine +
                    fuel;
        }
    }
}
