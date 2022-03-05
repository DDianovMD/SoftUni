using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main()
        {
            Queue<string> cars = new Queue<string>();
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            
            int carsPassedCounter = 0;
            bool crashHeppened = false;

            var command = Console.ReadLine();

            while (command.ToUpper() != "END")
            {
                if (command.ToLower() != "green")
                {
                    cars.Enqueue(command);
                }
                else if (command.ToLower() == "green")
                {
                    int greenTimer = greenLightDuration;         

                    while (cars.Count > 0 && greenTimer >= cars.Peek().Length)
                    {
                        greenTimer -= cars.Peek().Length;
                        cars.Dequeue();
                        carsPassedCounter++;                        
                    }

                    if (greenTimer > 0 && cars.Count > 0)
                    {
                        int timeleft = greenTimer + freeWindowDuration;

                        if (cars.Count > 0 && timeleft >= cars.Peek().Length)
                        {
                            timeleft -= cars.Peek().Length;
                            cars.Dequeue();
                            carsPassedCounter++;
                        }
                        else if (cars.Count > 0 && timeleft < cars.Peek().Length)
                        {
                            string hitCar = cars.Peek().ToString();
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {hitCar[timeleft]}.");
                            crashHeppened = true;
                            break;
                        }
                    }
                    
                }

                command = Console.ReadLine();
            }

            if (crashHeppened == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassedCounter} total cars passed the crossroads.");
            }
        }
    }
}
