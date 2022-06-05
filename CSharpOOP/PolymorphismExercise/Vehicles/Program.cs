using System;

namespace Vehicles
{
    class Program
    {
        static void Main()
        {

            string[] userInput = Console.ReadLine().Split();

            Car car = new Car(double.Parse(userInput[1]), double.Parse(userInput[2]));

            userInput = Console.ReadLine().Split();

            Truck truck = new Truck(double.Parse(userInput[1]), double.Parse(userInput[2]));

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs ; i++)
            {
                userInput = Console.ReadLine().Split();

                if (userInput[0] == "Drive")
                {
                    if (userInput[1] == "Car")
                    {
                        car.Drive(double.Parse(userInput[2]));
                    }
                    else
                    {
                        truck.Drive(double.Parse(userInput[2]));
                    }
                }
                else
                {
                    if (userInput[1] == "Car")
                    {
                        car.Refuel(double.Parse(userInput[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(userInput[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
