using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;
        private bool hired = false;

        public string Name { get => this.name; private set => this.name = value; }
        public string Type { get => this.type; private set => this.type = value; }
        public double Rate { get => this.rate; private set => this.rate = value; }
        public bool Hired { get => this.hired; set => this.hired = value; }
        public int Days { get => this.days; set => this.days = value; }

        public Renovator(string name, string type, double rate, int days)
        {
            this.name = name;
            this.type = type;
            this.rate = rate;
            this.days = days;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"-Renovator: {this.name}");
            stringBuilder.AppendLine($"--Specialty: {this.type}");
            stringBuilder.AppendLine($"--Rate per day: {this.rate} BGN");

            return stringBuilder.ToString().Trim();
        }
    }
}
