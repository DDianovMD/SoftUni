using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    public class Truck
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int weight { get; set; }

        public Truck(string brand, string model, int weight)
        {
            this.brand = brand;
            this.model = model;
            this.weight = weight;
        }
    }

    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int horsePower { get; set; }

        public Car(string brand, string model, int horsePower)
        {
            this.brand = brand;
            this.model = model;
            this.horsePower = horsePower;
        }
    }

    public class Catalog
    {
        public List<Truck> trucks { get; set; }
        public List<Car> cars { get; set; }

        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.cars = cars;
            this.trucks = trucks;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine()
            .Split("/", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            List<Car> cars = new List<Car>();

            List<Truck> trucks = new List<Truck>();

            while (userInput[0].ToLower() != "end")
            {
                if (userInput[0].ToLower() == "car")
                {
                    Car car = new Car(userInput[1], userInput[2], int.Parse(userInput[3]));
                    cars.Add(car);
                }
                else if (userInput[0].ToLower() == "truck")
                {
                    Truck truck = new Truck(userInput[1], userInput[2], int.Parse(userInput[3]));
                    trucks.Add(truck);
                }

                userInput = Console.ReadLine()
                .Split("/", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Catalog vehicleCatalog = new Catalog(cars, trucks);

            // Print result
            if (vehicleCatalog.cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in vehicleCatalog.cars.OrderBy(x => x.brand))
                {
                    Console.WriteLine($"{car.brand}: {car.model} - {car.horsePower}hp");
                }
            }

            if (vehicleCatalog.trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in vehicleCatalog.trucks.OrderBy(x => x.brand))
                {
                    Console.WriteLine($"{truck.brand}: {truck.model} - {truck.weight}kg");
                }
            }
        }
    }
}
