using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main()
        {
            // key - string forceUser; value - string forceSide
            Dictionary<string, string> forcebook = new Dictionary<string, string>();

            // key - string side; value - membersCounter
            Dictionary<string, int> membersOnEachSide = new Dictionary<string, int>();

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "Lumpawaroo")
                {
                    break;
                }

                List<string> userAndSide = new List<string>();
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (userInput.Contains(" | "))
                {
                    userAndSide = userInput.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

                    forceSide = userAndSide[0];
                    forceUser = userAndSide[1];

                    if (forcebook.ContainsKey(forceUser) == false)
                    {
                        forcebook.Add(forceUser, forceSide);

                        if (membersOnEachSide.ContainsKey(forceSide) == false)
                        {
                            membersOnEachSide.Add(forceSide, 1);
                        }
                        else
                        {
                            membersOnEachSide[forceSide]++;
                        }
                    }
                }
                else if (userInput.Contains(" -> "))
                {
                    userAndSide = userInput.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();

                    forceUser = userAndSide[0];
                    forceSide = userAndSide[1];

                    if (forcebook.ContainsKey(forceUser) == false)
                    {
                        forcebook.Add(forceUser, forceSide);

                        if (membersOnEachSide.ContainsKey(forceSide) == false)
                        {
                            membersOnEachSide.Add(forceSide, 1);
                        }
                        else
                        {
                            membersOnEachSide[forceSide]++;
                        }
                    }
                    else
                    {
                        membersOnEachSide[forcebook[forceUser]]--;
                        forcebook[forceUser] = forceSide;
                        membersOnEachSide[forceSide]++;
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            // Print results

            foreach (var kvp in membersOnEachSide.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value}");
                }

                foreach (var kvp2 in forcebook.OrderBy(x => x.Key))
                {
                    if (kvp2.Value == kvp.Key)
                    {
                        Console.WriteLine($"! {kvp2.Key}");
                    }
                }
            }
        }
    }
}
