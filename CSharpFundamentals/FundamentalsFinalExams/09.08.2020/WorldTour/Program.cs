using System;
using System.Linq;

namespace WorldTour
{
    class Program
    {
        static void Main()
        {
            string stops = Console.ReadLine();
            string modifiedStops = string.Empty;

            bool keepGoing = true;

            while (keepGoing)
            {
                string[] command = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0].ToLower() == "travel")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    if (command[0].ToLower() == "add stop")
                    {
                        int index = int.Parse(command[1]);
                        string stop = command[2];

                        if (index >= 0 && index < stops.Length)
                        {
                            for (int i = 0; i < index; i++)
                            {
                                modifiedStops += stops[i];                                
                            }

                            for (int i = 0; i < stop.Length; i++)
                            {
                                modifiedStops += stop[i];
                            }

                            for (int i = index; i < stops.Length; i++)
                            {
                                modifiedStops += stops[i];
                            }
                            
                            stops = modifiedStops;
                            modifiedStops = string.Empty;                            
                        }
                        Console.WriteLine(stops);
                    }
                    else if (command[0].ToLower() == "remove stop")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);

                        if (startIndex >= 0 && endIndex < stops.Length)
                        {
                            for (int i = 0; i < startIndex; i++)
                            {
                                modifiedStops += stops[i];
                            }

                            for (int i = endIndex + 1; i < stops.Length; i++)
                            {
                                modifiedStops += stops[i];
                            }

                            stops = modifiedStops;
                            modifiedStops = string.Empty;                            
                        }
                        Console.WriteLine(stops);
                    }
                    else if (command[0].ToLower() == "switch")
                    {
                        string oldString = command[1];
                        string newString = command[2];

                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);                            
                        }
                        Console.WriteLine(stops);
                    }
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
