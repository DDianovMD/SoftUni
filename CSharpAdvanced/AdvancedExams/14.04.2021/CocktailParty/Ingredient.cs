using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        private string name;
        private int alcohol;
        private int quantity;

        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Alcohol { get => this.alcohol; set => this.alcohol = value; }
        public int Quantity { get => this.quantity; set => this.quantity = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Ingredient: {this.Name}");
            result.AppendLine($"Quantity: {this.Quantity}");
            result.AppendLine($"Alcohol: {this.Alcohol}");

            return result.ToString().Trim();
        }
    }
}
