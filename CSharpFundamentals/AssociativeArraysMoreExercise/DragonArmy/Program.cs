using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    public class Dragon
    {
        public string type { get; set; }
        public string name { get; set; }
        public double damage { get; set; }
        public double health { get; set; }
        public double armor { get; set; }

        public Dragon(string type, string name, string damage, string health, string armor)
        {
            this.type = type;
            this.name = name;

            // Set dragon's damage if not "null" and can be parsed as int or set default value of 45.
            if (double.TryParse(damage, out double dmg))
            {
                this.damage = double.Parse(damage);
            }
            else
            {
                this.damage = 45;
            }

            // Set dragon's health if not "null" and can be parsed as int or set default value of 250.
            if (double.TryParse(health, out double hp))
            {
                this.health = double.Parse(health);
            }
            else
            {
                this.health = 250;
            }

            // Set dragon's armor if not "null" and can be parsed as int or set default value of 10;
            if (double.TryParse(armor, out double arm))
            {
                this.armor = double.Parse(armor);
            }
            else
            {
                this.armor = 10;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dragonTypeAndNames = new Dictionary<string, List<string>>();
            List<Dragon> dragons = new List<Dragon>();

            List<string> userInput = new List<string>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                bool dragonIsExistingAlready = false;

                for (int j = 0; j < dragons.Count; j++)
                {
                    if (dragons[j].type == userInput[0] && dragons[j].name == userInput[1])
                    {
                        dragonIsExistingAlready = true;

                        if (double.TryParse(userInput[2], out double dmg))
                        {
                            dragons[j].damage = double.Parse(userInput[2]);
                        }
                        else
                        {
                            dragons[j].damage = 45;
                        }

                        if (double.TryParse(userInput[3], out double hp))
                        {
                            dragons[j].health = double.Parse(userInput[3]);
                        }
                        else
                        {
                            dragons[j].health = 250;
                        }

                        if (double.TryParse(userInput[4], out double armor))
                        {
                            dragons[j].armor = double.Parse(userInput[4]);
                        }
                        else
                        {
                            dragons[j].armor = 10;
                        }                        
                        break;
                    }
                }

                if (dragonIsExistingAlready == false)
                {
                    Dragon currentDragon = new Dragon(userInput[0], userInput[1], userInput[2], userInput[3], userInput[4]);
                    dragons.Add(currentDragon);

                    if (dragonTypeAndNames.ContainsKey(userInput[0]) == false)
                    {
                        dragonTypeAndNames.Add(userInput[0], new List<string> { userInput[1] });
                    }
                    else
                    {
                        dragonTypeAndNames[userInput[0]].Add(userInput[1]);
                    }
                }
            }

            // Print output
            for (int i = 0; i < dragonTypeAndNames.Count; i++)
            {
                double damageSum = 0;
                double healthSum = 0;
                double armorSum = 0;
                int sameTypeDragonsCounter = 0;

                foreach (var dragon in dragons.Where(x => x.type == dragonTypeAndNames.Keys.ElementAt(i)))
                {
                    damageSum += dragon.damage;
                    healthSum += dragon.health;
                    armorSum += dragon.armor;
                    sameTypeDragonsCounter++;                    
                }

                Console.WriteLine($"{dragonTypeAndNames.Keys.ElementAt(i)}::({damageSum / sameTypeDragonsCounter:F2}/" +
                                                                           $"{healthSum / sameTypeDragonsCounter:F2}/" +
                                                                           $"{armorSum / sameTypeDragonsCounter:F2})");

                foreach (var dragon in dragons.Where(x => x.type == dragonTypeAndNames.Keys.ElementAt(i)).OrderBy(x => x.name).ToList())
                {
                    Console.WriteLine($"-{dragon.name} -> damage: {dragon.damage}, health: {dragon.health}, armor: {dragon.armor}");
                }
            }
        }
    }
}
