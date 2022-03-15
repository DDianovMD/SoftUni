using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] userInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car currentCar = new Car(userInput[0], double.Parse(userInput[1]), double.Parse(userInput[2]));
                carsList.Add(currentCar);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0].ToLower() == "end")
                {
                    break;
                }

                for (int i = 0; i < carsList.Count; i++)
                {
                    if (carsList[i].Model == command[1])
                    {
                        carsList[i].Drive(double.Parse(command[2]));
                    }
                }
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
