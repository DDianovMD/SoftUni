using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Car
    {
        public string model { get; set; }
        public Engine carEngine { get; set; }
        public Cargo carCargo { get; set; }
        public Car (string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            this.model = model;

            this.carEngine = new Engine(engineSpeed, enginePower);

            this.carCargo = new Cargo(cargoWeight, cargoType);
        }
    }
    public class Engine
    {
        public int engineSpeed { get; set; }
        public int enginePower { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }

    }
    public class Cargo
    {
        public int cargoWeight { get; set; }
        public string cargoType { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                Car currentCar = new Car(userInput[0], int.Parse(userInput[1]), int.Parse(userInput[2]), int.Parse(userInput[3]), userInput[4]);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            foreach (var car in cars)
            {
                if (command == "fragile")
                {
                    if (car.carCargo.cargoType == "fragile" && car.carCargo.cargoWeight < 1000)
                    {
                        Console.WriteLine(car.model);
                    }
                }
                else if (command == "flamable")
                {
                    if (car.carCargo.cargoType == "flamable" && car.carEngine.enginePower > 250)
                    {
                        Console.WriteLine(car.model);
                    }
                }
            }
        }
    }
}
