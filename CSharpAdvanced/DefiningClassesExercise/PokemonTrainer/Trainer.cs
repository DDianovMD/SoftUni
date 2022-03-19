using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            Pokemons.Add(pokemon);
        }
    }
}
