using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;
        private string name;
        private int capacity;
        private int maxAlcoholLevel;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.ingredients = new List<Ingredient>();
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int MaxAlcoholLevel { get => this.maxAlcoholLevel; set => this.maxAlcoholLevel = value; }
        public List<Ingredient> Ingredients { get => this.ingredients; set => this.ingredients = value; }

        public void Add(Ingredient ingredient)
        {
            if (this.Ingredients.Where(x => x.Name == ingredient.Name).Count() == 0)
            {
                if (this.Ingredients.Count < this.Capacity)
                {
                    if (ingredient.Alcohol + this.CurrentAlcoholLevel() <= this.MaxAlcoholLevel)
                    {
                        this.Ingredients.Add(ingredient);
                    }
                }
            }
        }

        public bool Remove(string name)
        {
            return this.Ingredients.Remove(this.Ingredients.Where(x => x.Name == name).ElementAt(0));
        }

        public Ingredient FindIngredient(string name)
        {
            Ingredient result = null;

            foreach (Ingredient ingredient in this.Ingredients)
            {
                if (ingredient.Name == name)
                {
                    result = ingredient;
                    break;
                }
            }

            return result;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return this.Ingredients.OrderByDescending(x => x.Alcohol).ElementAt(0);
        }

        public int CurrentAlcoholLevel()
        {
            int alcoholAmount = 0;

            foreach (Ingredient ingredient in this.Ingredients)
            {
                alcoholAmount += ingredient.Alcohol;
            }

            return alcoholAmount;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel()}");
            foreach (Ingredient ingredient in this.Ingredients)
            {
                result.AppendLine(ingredient.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
