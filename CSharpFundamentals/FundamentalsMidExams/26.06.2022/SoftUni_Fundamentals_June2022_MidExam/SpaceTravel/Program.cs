using System;
using System.Linq;

namespace SpaceTravel
{
    class Program
    {
        static void Main()
        {
            string[] userInput = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries);

            int fuelAmount = int.Parse(Console.ReadLine());
            int ammunitionAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < userInput.Length; i++)
            {
                string[] command = userInput[i].Split(" ").ToArray();

                if (command[0] != "Titan")
                {
                    int amount = int.Parse(command[1]);

                    if (command[0] == "Travel")
                    {
                        if (fuelAmount >= amount)
                        {
                            fuelAmount -= amount;
                            Console.WriteLine($"The spaceship travelled {amount} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                    }
                    else if (command[0] == "Enemy")
                    {
                        if (ammunitionAmount >= amount)
                        {
                            ammunitionAmount -= amount;
                            Console.WriteLine($"An enemy with {amount} armour is defeated.");
                        }
                        else
                        {
                            if (fuelAmount >= amount * 2)
                            {
                                fuelAmount -= amount * 2;
                                Console.WriteLine($"An enemy with {amount} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                break;
                            }
                        }
                    }
                    else if (command[0] == "Repair")
                    {
                        fuelAmount += amount;
                        ammunitionAmount += amount * 2;

                        Console.WriteLine($"Ammunitions added: {amount * 2}.");
                        Console.WriteLine($"Fuel added: {amount}.");
                    }
                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    break;
                }
            }
        }
    }
}
