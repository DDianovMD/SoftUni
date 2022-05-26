using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private int baseCaloriesPerGram = 2;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public int BaseCaloriesPerGram
        {
            get => baseCaloriesPerGram;           
        }

        private string FlourType
        {
            get => flourType;

            set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        private string BakingTechnique
        {
            get => bakingTechnique;

            set
            {
                if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        private int Weight
        {
            get => weight;

            set
            {
                if (value >= 1 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }
            }
        }

        public double TotalCalories()
        {
            double flourTypeModifier = 0;
            double bakingTechniqueModifier = 0;

            switch (FlourType.ToLower())
            {
                case "white":
                    flourTypeModifier = 1.5;
                    break;
                case "wholegrain":
                    flourTypeModifier = 1.0;
                    break;
                default:
                    flourTypeModifier = 0;
                    break;
            }

            switch (BakingTechnique.ToLower())
            {
                case "crispy":
                    bakingTechniqueModifier = 0.9;
                    break;
                case "chewy":
                    bakingTechniqueModifier = 1.1;
                    break;
                case "homemade":
                    bakingTechniqueModifier = 1.0;
                    break;
                default:
                    bakingTechniqueModifier = 0;
                    break;
            }

            return Weight * BaseCaloriesPerGram * flourTypeModifier * bakingTechniqueModifier;
        }
    }
}
