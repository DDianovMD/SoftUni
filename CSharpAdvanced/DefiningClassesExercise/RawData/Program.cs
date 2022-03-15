using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
       public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] userInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car currentCar = new Car(userInput[0],
                    int.Parse(userInput[1]), int.Parse(userInput[2]),
                    int.Parse(userInput[3]), userInput[4],
                    double.Parse(userInput[5]), int.Parse(userInput[6]),
                    double.Parse(userInput[7]), int.Parse(userInput[8]),
                    double.Parse(userInput[9]), int.Parse(userInput[10]),
                    double.Parse(userInput[11]), int.Parse(userInput[12]));

                cars.Add(currentCar);
            }

            string filter = Console.ReadLine();

            // Print filtered result

            if (filter.ToLower() == "fragile") // print all cars whose cargo is "fragile" and have a pressure of a single tire < 1
            {
                foreach (var car in cars.Where(x => x.cargo.Type == "fragile"))
                {
                    foreach (var tire in car.Tires.Values)
                    {
                        bool exitCycle = false;
                        foreach (var carPressure in tire.Keys)
                        {
                            if (carPressure < 1.0)
                            {
                                Console.WriteLine(car.Model);
                                exitCycle = true;
                                break;
                            }
                        }

                        if (exitCycle)
                        {
                            break;
                        }
                    }
                }
            }
            else // print all cars, whose cargo is "flammable" and have engine power > 250
            {
                foreach (var car in cars.Where(x => x.cargo.Type == "flammable"))
                {
                    if (car.engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
