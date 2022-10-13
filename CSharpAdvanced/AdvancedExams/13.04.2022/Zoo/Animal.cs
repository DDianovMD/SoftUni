using System.Text;

namespace Zoo
{
    public class Animal
    {
        private string species;
        private string diet;
        private double weight;
        private double length;

        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Length = length;
        }

        public string Species { get => this.species; set => this.species = value; }
        public string Diet { get => this.diet; set => this.diet = value; }
        public double Weight { get => this.weight; set => this.weight = value; }
        public double Length { get => this.length; set => this.length = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The {this.Species} is a {this.Diet} and weighs {this.Weight} kg.");

            return result.ToString().Trim();
        }
    }
}
