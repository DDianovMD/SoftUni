using System;
using System.Linq;
using System.Collections.Generic;


namespace VehicleCatalogue
{
    public class VehicleCatalogue
    {
        public string type { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int horsePower { get; set; }

        public VehicleCatalogue(string type, string model, string color, int horsePower)
        {
            this.type = type;
            this.model = model;
            this.color = color;
            this.horsePower = horsePower;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<VehicleCatalogue> catalogue = new List<VehicleCatalogue>();

            List<string> userInput = new List<string>();

            bool keepGoing = true;

            while (keepGoing)
            {
                userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (userInput[0].ToLower() == "end")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    if (userInput[0] == "car")
                    {
                        userInput[0] = "Car";
                    }
                    else if (userInput[0] == "truck")
                    {
                        userInput[0] = "Truck";
                    }

                    VehicleCatalogue currentVehicle = new VehicleCatalogue(userInput[0], userInput[1], userInput[2], int.Parse(userInput[3]));
                    catalogue.Add(currentVehicle);
                    userInput.Clear();
                }
            }

            string vehicleInfo = Console.ReadLine();

            while (vehicleInfo.ToLower() != "close the catalogue")
            {
                foreach (var vehicle in catalogue)
                {
                    if (vehicleInfo == vehicle.model)
                    {
                        Console.WriteLine($"Type: {vehicle.type}");
                        Console.WriteLine($"Model: {vehicle.model}");
                        Console.WriteLine($"Color: {vehicle.color}");
                        Console.WriteLine($"Horsepower: {vehicle.horsePower}");
                    }
                }
                vehicleInfo = Console.ReadLine();
            }

            double sumOfCarsHorsePower = 0;
            int numberOfCars = 0;

            double sumOfTrucksHorsePower = 0;
            int numberOfTrucks = 0;

            foreach (var vehicle in catalogue)
            {                

                if (vehicle.type == "Car")
                {
                    sumOfCarsHorsePower += vehicle.horsePower;
                    numberOfCars++;
                }
                else if (vehicle.type == "Truck")
                {
                    sumOfTrucksHorsePower += vehicle.horsePower;
                    numberOfTrucks++;
                }
            }

            if (numberOfCars > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {sumOfCarsHorsePower / numberOfCars:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (numberOfTrucks > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {sumOfTrucksHorsePower / numberOfTrucks:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");

            }

        }
    }
}
