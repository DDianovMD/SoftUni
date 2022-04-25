using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresList = new List<Tire[]>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "no more tires")
                {
                    break;
                }

                double[] tiresInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToArray();

                Tire firstTire = new Tire((int)tiresInfo[0], tiresInfo[1]);
                Tire secondTire = new Tire((int)tiresInfo[2], tiresInfo[3]);
                Tire thirdTire = new Tire((int)tiresInfo[4], tiresInfo[5]);
                Tire fourthTire = new Tire((int)tiresInfo[6], tiresInfo[7]);

                Tire[] currentCarTires = new Tire[]
                {
                    firstTire,
                    secondTire,
                    thirdTire,
                    fourthTire
                };

                tiresList.Add(currentCarTires);
            }

            List<Engine> enginesList = new List<Engine>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "engines done")
                {
                    break;
                }

                double[] enginesInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .Select(double.Parse)
                                              .ToArray();

                int horsePower = (int)enginesInfo[0];
                double cubicCapacity = enginesInfo[1];

                Engine currentEngine = new Engine(horsePower, cubicCapacity);

                enginesList.Add(currentEngine);
            }

            List<Car> cars = new List<Car>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "show special")
                {
                    break;
                }

                string[] carInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Engine currentEngine = enginesList[int.Parse(carInfo[5])];
                Tire[] tires = tiresList[int.Parse(carInfo[6])];

                Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, tires);

                cars.Add(currentCar);
            }

            List<Car> specialCars = new List<Car>();

            foreach (var car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    double tiresPressureSum = 0;

                    foreach (var tire in car.Tires)
                    {
                        tiresPressureSum += tire.Pressure;
                    }                                            

                    if (tiresPressureSum >= 9.0 && tiresPressureSum <= 10.0)
                    {
                        car.Drive(20);
                        specialCars.Add(car);
                    }
                }
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
