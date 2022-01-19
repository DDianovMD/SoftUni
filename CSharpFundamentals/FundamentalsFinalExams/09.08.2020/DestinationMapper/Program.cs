using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            Regex validPlaces = new Regex("=[A-Z][A-Za-z]+=|/[A-Z][A-Za-z]+/");
            List<Match> matches = validPlaces.Matches(userInput).ToList();
            List<string> places = new List<string>();
            int travelPoints = 0;

            foreach (var match in matches.Where(x => x.Length >= 5))
            {
                string currentPlace = string.Empty;

                for (int i = 0; i < match.Length; i++)
                {                    
                    if (match.ToString()[i] != '=' && match.ToString()[i] != '/')
                    {
                        currentPlace += match.ToString()[i];
                    }
                }

                places.Add(currentPlace);
                currentPlace = string.Empty;
            }

            foreach (var place in places)
            {
                travelPoints += place.Length;
            }

            // Print output
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", places));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
