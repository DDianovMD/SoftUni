using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main()
        {
            // key - vlogger nickname, value - vlogger's followers
            Dictionary<string, List<string>> vloggerFollowers = new Dictionary<string, List<string>>();
            // key - vlogger nickname, value - number of followed vloggers
            Dictionary<string, int> vloggerFollowed = new Dictionary<string, int>();

            string userInput = string.Empty;

            while (true)
            {
                userInput = Console.ReadLine();
                string[] command = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0].ToLower() == "statistics")
                {
                    break;
                }

                string vloggerName = command[0];
                string joinOrFollow = command[1];
                string followedVlogger = command[2];

                if (joinOrFollow.ToLower() == "joined")
                {
                    if (vloggerFollowers.ContainsKey(vloggerName) == false)
                    {
                        vloggerFollowers.Add(vloggerName, new List<string>());
                        vloggerFollowed.Add(vloggerName, 0);
                    }
                }

                // Fill list of followers for each vlogger
                if (joinOrFollow.ToLower() == "followed")
                {
                    if (vloggerFollowers.ContainsKey(vloggerName) && vloggerFollowers.ContainsKey(followedVlogger)) // check if both vloggers exist
                    {
                        if (vloggerName != followedVlogger && vloggerFollowers[followedVlogger].Contains(vloggerName) == false) // check if vlogger is not trying to follow himself and he's not already a follower
                        {
                            vloggerFollowers[followedVlogger].Add(vloggerName);
                        }
                    }
                }
            }

            // Calculate how many people each vlogger is following
            for (int i = 0; i < vloggerFollowed.Keys.Count; i++)
            {
                int peopleFollowedCounter = 0;

                foreach (var follower in vloggerFollowers)
                {
                    if (follower.Value.Contains(vloggerFollowed.Keys.ElementAt(i)))
                    {
                        peopleFollowedCounter++;
                    }
                }

                vloggerFollowed[vloggerFollowed.Keys.ElementAt(i)] = peopleFollowedCounter;
            }

            // Print result
            Console.WriteLine($"The V-Logger has a total of {vloggerFollowed.Keys.Count} vloggers in its logs.");

            int index = 1;

            foreach (var vlogger in vloggerFollowers.OrderByDescending(x => x.Value.Count).ThenBy(x => vloggerFollowed[x.Key]))
            {
                Console.WriteLine($"{index}. {vlogger.Key} : {vlogger.Value.Count} followers, {vloggerFollowed[vlogger.Key]} following");
                if (index == 1)
                {
                    foreach (var follower in vloggerFollowers[vlogger.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                index++;
            }
        }
    }
}
