using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main()
        {
            // Create dictionary to store information
            // key -> continent, value -> Dictionary<country, List<cities>>

            Dictionary<string, Dictionary<string, List<string>>> continentsCountriesAndCities = new Dictionary<string, Dictionary<string, List<string>>>();

            // Receive number ot inputs "n"

            int n = int.Parse(Console.ReadLine());

            // Add continents, countries and cities

            for (int i = 0; i < n; i++)
            {
                string[] userInput = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                string continent = userInput[0];
                string country = userInput[1];
                string city = userInput[2];

                // Check if continent doesn't exist already so we don't get exception using .Add() method

                if (continentsCountriesAndCities.ContainsKey(continent) == false)
                {
                    continentsCountriesAndCities.Add(continent, new Dictionary<string, List<string>>());
                    continentsCountriesAndCities[continent].Add(country, new List<string> { city });
                }
                else
                {
                    // Check if country doesn't exist already so we don't get exception using .Add() method

                    if (continentsCountriesAndCities[continent].ContainsKey(country) == false)
                    {
                        continentsCountriesAndCities[continent].Add(country, new List<string> { city });
                    }
                    else
                    {
                        continentsCountriesAndCities[continent][country].Add(city);
                    }
                }
            }

            // Print result

            foreach (var kvp in continentsCountriesAndCities)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"  {kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
                }
            }
        }
    }
}
