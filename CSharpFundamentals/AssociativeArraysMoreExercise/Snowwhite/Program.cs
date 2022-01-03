using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    public class Dwarf
    {
        public string name { get; set; }
        public string hatColor { get; set; }
        public int physics { get; set; }
        public int sameColorHatCounter { get; set; }

        public Dwarf(string name, string hatColor, int physics)
        {
            this.name = name;
            this.hatColor = hatColor;
            this.physics = physics;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Key -> string hatColor
            // Value -> int numberOfDwarfs
            Dictionary<string, int> sameColorHatCounter = new Dictionary<string, int>();

            List<Dwarf> dwarfs = new List<Dwarf>();

            List<string> userInput = new List<string>();

            bool keepGoing = true;

            while (keepGoing)
            {
                userInput = Console.ReadLine()
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (userInput[0].ToLower() == "once upon a time")
                {
                    keepGoing = false;
                    break;
                }

                bool hatColorGroupIsExisting = false;

                foreach (var dwarf in dwarfs)
                {
                    // Check if hatColorGroup is existing already.
                    if (dwarf.hatColor == userInput[1]) 
                    {
                        hatColorGroupIsExisting = true;

                        if (hatColorGroupIsExisting)
                        {
                            for (int i = 0; i < dwarfs.Where(x => x.hatColor == userInput[1]).Count(); i++)
                            {
                                // Tf we have dwarf with same name in hatColorGroup => same dwarf => check dwarf's physics and update it if it's lower than current one.
                                if (dwarfs[i].name == userInput[0] && dwarfs[i].physics < int.Parse(userInput[2]))
                                {
                                    dwarfs[i].physics = int.Parse(userInput[2]);
                                    break;
                                }
                                // If we reach last dwarf in hatColorGroup and his name isn't the same => different dwarf => create new Dwarf object.
                                else if (dwarfs[i].name != userInput[0] && i == dwarfs.Where(x => x.hatColor == userInput[1]).Count() - 1)
                                {
                                    Dwarf currentDwarf = new Dwarf(userInput[0], userInput[1], int.Parse(userInput[2]));                                                                       
                                    dwarfs.Add(currentDwarf);
                                    sameColorHatCounter[userInput[1]]++;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }

                if (hatColorGroupIsExisting == false)
                {
                    Dwarf currentDwarf = new Dwarf(userInput[0], userInput[1], int.Parse(userInput[2]));                                      
                    dwarfs.Add(currentDwarf);
                    sameColorHatCounter.Add(userInput[1], 1);
                }
            }

            // Set hatColorCounter (number of all dwarfs with same hat color) - used for ordering dwarfs according to output requirements.
            for (int i = 0; i < dwarfs.Count; i++)
            {
                dwarfs[i].sameColorHatCounter = sameColorHatCounter[dwarfs[i].hatColor];
            }

            // Print output
            foreach (var dwarf in dwarfs.OrderByDescending(x => x.physics).ThenByDescending(x => x.sameColorHatCounter))
            {
                Console.WriteLine($"({dwarf.hatColor}) {dwarf.name} <-> {dwarf.physics}");
            }
        }
    }
}
