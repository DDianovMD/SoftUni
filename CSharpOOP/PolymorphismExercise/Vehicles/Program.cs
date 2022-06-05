using System;

namespace Vehicles
{
    class Program
    {
        static void Main()
        {
            // Vehicles problem logic

            // string[] userInput = Console.ReadLine().Split();
            // 
            // Car car = new Car(double.Parse(userInput[1]), double.Parse(userInput[2]));
            // 
            // userInput = Console.ReadLine().Split();
            // 
            // Truck truck = new Truck(double.Parse(userInput[1]), double.Parse(userInput[2]));
            // 
            // int numberOfInputs = int.Parse(Console.ReadLine());
            // 
            // for (int i = 0; i < numberOfInputs ; i++)
            // {
            //     userInput = Console.ReadLine().Split();
            // 
            //     if (userInput[0] == "Drive")
            //     {
            //         if (userInput[1] == "Car")
            //         {
            //             car.Drive(double.Parse(userInput[2]));
            //         }
            //         else
            //         {
            //             truck.Drive(double.Parse(userInput[2]));
            //         }
            //     }
            //     else
            //     {
            //         if (userInput[1] == "Car")
            //         {
            //             car.Refuel(double.Parse(userInput[2]));
            //         }
            //         else
            //         {
            //             truck.Refuel(double.Parse(userInput[2]));
            //         }
            //     }
            // }
            // 
            // Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            // Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");

            // Vehicle Extension problem logic

            string[] userInput = Console.ReadLine().Split();

            Car car = new Car(double.Parse(userInput[1]), double.Parse(userInput[2]), double.Parse(userInput[3]));

            userInput = Console.ReadLine().Split();

            Truck truck = new Truck(double.Parse(userInput[1]), double.Parse(userInput[2]), double.Parse(userInput[3]));

            userInput = Console.ReadLine().Split();

            Bus bus = new Bus(double.Parse(userInput[1]), double.Parse(userInput[2]), double.Parse(userInput[3]));

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                userInput = Console.ReadLine().Split();

                if (userInput[0] == "Drive")
                {
                    if (userInput[1] == "Car")
                    {
                        car.Drive(double.Parse(userInput[2]));
                    }
                    else if (userInput[1] == "Truck")
                    {
                        truck.Drive(double.Parse(userInput[2]));
                    }
                    else
                    {
                        bus.Drive(double.Parse(userInput[2]));
                    }
                }
                else if (userInput[0] == "Refuel")
                {
                    if (userInput[1] == "Car")
                    {
                        car.Refuel(double.Parse(userInput[2]));
                    }
                    else if (userInput[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(userInput[2]));
                    }
                    else
                    {
                        bus.Refuel(double.Parse(userInput[2]));
                    }
                }
                else
                {
                    bus.DriveEmpty(double.Parse(userInput[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
