using System.Text;

namespace SkiRental
{
    public class Ski
    {
        private string manufacturer;
        private string model;
        private int year;

        public Ski(string manufacturer, string model, int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
        }

        public string Manufacturer { get => this.manufacturer; set => this.manufacturer = value; }
        public string Model { get => this.model; set => this.model = value; }
        public int Year { get => this.year; set => this.year = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Manufacturer} - {this.Model} - {this.Year}");

            return result.ToString().Trim();
        }
    }
}
