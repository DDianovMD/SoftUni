using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        public static void Main()
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputData.Length == 2)
                {
                    Engine currentEngine = new Engine(inputData[0], int.Parse(inputData[1]));
                    engines.Add(currentEngine);
                }
                else if (inputData.Length == 3)
                {
                    if (int.TryParse(inputData[2], out int a))
                    {
                        Engine currentEngine = new Engine(inputData[0], int.Parse(inputData[1]), int.Parse(inputData[2]));
                        engines.Add(currentEngine);
                    }
                    else
                    {
                        Engine currentEngine = new Engine(inputData[0], int.Parse(inputData[1]), inputData[2]);
                        engines.Add(currentEngine);
                    }
                }
                else if (inputData.Length == 4)
                {
                    Engine currentEngine = new Engine(inputData[0], int.Parse(inputData[1]), int.Parse(inputData[2]), inputData[3]);
                    engines.Add(currentEngine);
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine currentEngine = new Engine();

                for (int j = 0; j < engines.Count; j++)
                {
                    if (inputData[1] == engines[j].Model)
                    {
                        currentEngine = engines[j];
                    }
                }
                
                if (inputData.Length == 2)
                {
                    Car currentCar = new Car(inputData[0], currentEngine);
                    cars.Add(currentCar);
                }
                else if (inputData.Length == 3)
                {
                    if (int.TryParse(inputData[2], out int a))
                    {
                        Car currentCar = new Car(inputData[0], currentEngine, int.Parse(inputData[2]));
                        cars.Add(currentCar);
                    }
                    else
                    {
                        Car currentCar = new Car(inputData[0], currentEngine, inputData[2]);
                        cars.Add(currentCar);
                    }
                }
                else if (inputData.Length == 4)
                {
                    Car currentCar = new Car(inputData[0], currentEngine, int.Parse(inputData[2]), inputData[3]);
                    cars.Add(currentCar);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement != null)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine("    Displacement: n/a");
                }

                if (car.Engine.Efficiency != string.Empty)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine("    Efficiency: n/a");
                }

                if (car.Weight != null)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine("  Weight: n/a");
                }

                if (car.Color != string.Empty)
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine("  Color: n/a");
                }             
            }
        }
    }
}
