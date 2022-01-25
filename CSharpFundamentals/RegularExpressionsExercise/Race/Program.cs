using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main()
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (var participant in participants)
            {
                racers.Add(participant, 0);
            }

            string pattern = @"[\W]+";

            Regex regex = new Regex(pattern);
            Regex alphabet = new Regex("[A-Za-z]");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "end of race")
            {
                string[] filteredInput = regex.Split(userInput);

                string racer = string.Empty;
                string distanceString = string.Empty;
                int distance = 0;

                foreach (var item in filteredInput.Where(x => x.Length > 0))
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        // Extract racer name
                        if (alphabet.IsMatch(item[i].ToString()))
                        {
                            racer += item[i];
                        }
                        // Extract numbers to calculate traveled distance
                        else
                        {
                            distanceString += item[i];
                        }
                    }
                }

                // Calculate distance
                for (int i = 0; i < distanceString.Length; i++)
                {                
                    distance += int.Parse(distanceString[i].ToString());
                }

                // Update distance if racer exists in participants list
                if (racers.ContainsKey(racer))
                {
                    racers[racer] += distance;
                }

                userInput = Console.ReadLine();
            }

            racers = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //Print output
            Console.WriteLine($"1st place: {racers.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {racers.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {racers.ElementAt(2).Key}");
        }
    }
}
