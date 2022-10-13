using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals = new List<Animal>();
        private string name;
        private int capacity;

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }

        public string AddAnimal(Animal animal)
        {
            if (this.Animals.Count < this.Capacity)
            {
                if (animal.Species == null || animal.Species == " ")
                {
                    return "Invalid animal species.";
                }

                if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }

                this.Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
            else
            {
                return "The zoo is full.";
            }
        }

        public int RemoveAnimals(string species)
        {
            int removedAnimalsCount = this.Animals.RemoveAll(animal => animal.Species == species);

            return removedAnimalsCount;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return this.Animals.Where(animal => animal.Diet == diet).ToList();
        }

        public Animal GetAnimalByWeight(double weight)
        {
            return this.Animals.Where(animal => animal.Weight == weight).ElementAt(0);
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int animalsCount = this.Animals.Where(animal => animal.Length >= minimumLength && animal.Length <= maximumLength).Count();

            return $"There are {animalsCount} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
