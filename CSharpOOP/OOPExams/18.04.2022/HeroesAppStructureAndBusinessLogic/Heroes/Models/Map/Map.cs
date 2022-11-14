using Heroes.Models.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Models.Map
{
    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            List<IHero> knights = new List<IHero>();
            List<IHero> barbarians = new List<IHero>();

            foreach (var hero in players)
            {
                if (hero.GetType().Name == "Knight")
                {
                    knights.Add(hero);
                }
                else
                {
                    barbarians.Add(hero);
                }
            }

            while (knights.Any(hero => hero.IsAlive == true) &&
                   barbarians.Any(hero => hero.IsAlive == true))
            {
                foreach (var knight in knights)
                {
                    foreach (var barbarian in barbarians)
                    {
                        if (knight.IsAlive && barbarian.IsAlive)
                        {
                            barbarian.TakeDamage(knight.Weapon.DoDamage());
                        }
                    }
                }

                if (barbarians.Any(hero => hero.IsAlive == true))
                {
                    foreach (var barbarian in barbarians)
                    {
                        foreach (var knight in knights)
                        {
                            if (barbarian.IsAlive && knight.IsAlive)
                            {
                                knight.TakeDamage(barbarian.Weapon.DoDamage());
                            }
                        }
                    }
                }
            }

            if (knights.Any(hero => hero.IsAlive))
            {
                int deadKnightsCount = 0;

                foreach (var knight in knights)
                {
                    if (knight.IsAlive == false)
                    {
                        deadKnightsCount++;
                    }
                }

                return $"The knights took {deadKnightsCount} casualties but won the battle.";
            }
            else
            {
                int deadBarbariansCount = 0;

                foreach (var barbarian in barbarians)
                {
                    if (barbarian.IsAlive == false)
                    {
                        deadBarbariansCount++;
                    }
                }

                return $"The barbarians took {deadBarbariansCount} casualties but won the battle.";
            }
        }
    }
}
