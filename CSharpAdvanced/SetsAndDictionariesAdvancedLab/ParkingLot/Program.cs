using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main()
        {
            HashSet<string> parkingLot = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                if (command[0].ToLower() == "end")
                {
                    break;
                }

                string direction = command[0];
                string carNumber = command[1];

                if (direction.ToLower() == "in")
                {
                    parkingLot.Add(carNumber);
                }
                else if (direction.ToLower() == "out")
                {
                    parkingLot.Remove(carNumber);
                }
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
