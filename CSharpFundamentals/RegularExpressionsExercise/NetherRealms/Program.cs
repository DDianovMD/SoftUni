using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Demon
    {
        public string name { get; set; }
        public double health { get; set; }
        public double damage { get; set; }

        public Demon(string name, double health, double damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            List<Demon> demons = new List<Demon>();

            string separator = @"[,(\s)?]+";
            string alphabet = @"[^0-9\+\-\*\/\.\,\s]";
            string number = @"(?<double>(?:\+|\-)?\d+\.\d+)|(?<integer>(?:\+|\-)?\d+)";
            string specialSymbols = @"(\*)|(\/)";

            string[] demonsNames = Regex.Split(userInput, separator);

            foreach (var demon in demonsNames.Where(x => x.Length > 0))
            {   
                // Calculate each demon's health
                int health = 0;
                for (int i = 0; i < demon.Length; i++)
                {
                    if (Regex.IsMatch(demon[i].ToString(), alphabet))
                    {
                        health += (int)demon[i];
                    }                    
                }

                // Calculate damage
                double damage = 0;
                MatchCollection numbers = Regex.Matches(demon, number);

                foreach (Match num in numbers)
                {
                    if (num.ToString()[0] == '-')
                    {
                        double currentNumber = double.Parse(num.ToString().Remove(0, 1));
                        damage -= currentNumber;
                    }
                    else
                    {
                        damage += double.Parse(num.ToString());
                    }
                }

                MatchCollection damageModifiers = Regex.Matches(demon, specialSymbols);
                
                if (damageModifiers.Count != 0)
                {
                    foreach (Match modifier in damageModifiers)
                    {
                        if (modifier.ToString() == "*")
                        {
                            damage *= 2;
                        }
                        else if (modifier.ToString() == "/")
                        {
                            damage /= 2;
                        }
                    }
                }

                Demon currentDemon = new Demon(demon, health, damage);
                demons.Add(currentDemon);
            }

            foreach (Demon demon in demons.OrderBy(x => x.name))
            {
                Console.WriteLine($"{demon.name} - {demon.health} health, {demon.damage:F2} damage");
            }
        }
    }
}
