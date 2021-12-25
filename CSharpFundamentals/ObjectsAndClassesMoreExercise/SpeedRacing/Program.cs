using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Car
    {
        public string model { get; set; }
        public decimal fuelAmount { get; set; }
        public decimal fuelConsumptionPerKilometer { get; set; }
        public int traveledDistance { get; set; }

        public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKilometer)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.traveledDistance = 0;
        }

        public void DriveCar(string model, int amountOfKm)
        {

            if (this.model == model && this.fuelAmount - (this.fuelConsumptionPerKilometer * amountOfKm) >= 0)
            {
                this.fuelAmount -= this.fuelConsumptionPerKilometer * amountOfKm;
                this.traveledDistance += amountOfKm;
            }
            else if (this.model == model && this.fuelAmount - (this.fuelConsumptionPerKilometer * amountOfKm) < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Car currentCar = new Car(userInput[0], decimal.Parse(userInput[1]), decimal.Parse(userInput[2]));

                cars.Add(currentCar);
            }

            bool keepGoing = true;

            while (keepGoing)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0].ToLower() == "end")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    foreach (var car in cars)
                    {
                        car.DriveCar(command[1], int.Parse(command[2]));
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.traveledDistance}");
            }
        }
    }
}
