using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            List<string> trainersList = new List<string>();

            while (true)
            {
                string[] inputData = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputData[0].ToLower() == "tournament")
                {
                    break;
                }

                string trainerName = inputData[0];
                string pokemonName = inputData[1];
                string pokemonElement = inputData[2];
                int pokemonHealth = int.Parse(inputData[3]);                

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName].Pokemons.Add(currentPokemon);
                }
                else
                {
                    Trainer currentTrainer = new Trainer(trainerName, currentPokemon);
                    trainers.Add(trainerName, currentTrainer);
                }

                if (trainersList.Contains(trainerName) == false)
                {
                    trainersList.Add(trainerName);
                }                
            }

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "end")
                {
                    break;
                }

                for (int i = 0; i < trainersList.Count; i++)
                {
                    for (int j = 0; j < trainers[trainersList[i]].Pokemons.Count; j++)
                    {
                        bool hasPokemonWithGivenElement = false;
                        if (trainers[trainersList[i]].Pokemons[j].Element.ToLower() == userInput.ToLower())
                        {
                            hasPokemonWithGivenElement = true;
                            trainers[trainersList[i]].NumberOfBadges += 1;
                            break;
                        }
                        else if (hasPokemonWithGivenElement == false && j == trainers[trainersList[i]].Pokemons.Count - 1)
                        {
                            for (int k = 0; k < trainers[trainersList[i]].Pokemons.Count; k++)
                            {                                
                                if (trainers[trainersList[i]].Pokemons[k].Health <= 10)
                                {
                                    trainers[trainersList[i]].Pokemons.RemoveAt(k);
                                    k--;
                                    j--;
                                }
                                else
                                {
                                    trainers[trainersList[i]].Pokemons[k].Health -= 10;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges).ThenBy(x => trainersList))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
