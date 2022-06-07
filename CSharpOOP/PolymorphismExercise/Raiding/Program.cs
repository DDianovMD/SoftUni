using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main()
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            List<BaseHero> raidGroup = new List<BaseHero>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    var currentHero = new Druid(heroName);
                    raidGroup.Add(currentHero);
                }
                else if (heroType == "Paladin")
                {
                    var currentHero = new Paladin(heroName);
                    raidGroup.Add(currentHero);
                }
                else if (heroType == "Rogue")
                {
                    var currentHero = new Rogue(heroName);
                    raidGroup.Add(currentHero);
                }
                else if (heroType == "Warrior")
                {
                    var currentHero = new Warrior(heroName);
                    raidGroup.Add(currentHero);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
                bossPower -= hero.Power;
            }

            if (bossPower <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
