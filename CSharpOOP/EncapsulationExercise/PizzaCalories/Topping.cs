using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private int weight;
        private int baseCaloriesPerGram = 2;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        private string Type
        {
            get => type;

            set
            {
                if (value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        private int Weight
        {
            get => weight;

            set
            {
                if (value >= 1 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
            }
        }

        public int BaseCaloriesPerGram
        {
            get => baseCaloriesPerGram;
        }

        public double TotalCalories()
        {
            double modifier = 0;

            // Meat - 1.2;
            // Veggies - 0.8;
            // Cheese - 1.1;
            // Sauce - 0.9;

            switch (Type.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                case "sauce":
                    modifier = 0.9;
                    break;
                default:
                    break;
            }

            return Weight * BaseCaloriesPerGram * modifier;
        }
    }
}
