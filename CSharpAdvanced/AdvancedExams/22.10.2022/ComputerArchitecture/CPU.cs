using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        private string brand;
        private int cores;
        private double frequency;

        public CPU(string brand, int cores, double frequency)
        {
            this.Brand = brand;
            this.Cores = cores;
            this.Frequency = frequency;
        }

        public string Brand { get => this.brand; set => this.brand = value; }
        public int Cores { get => this.cores; set => this.cores = value; }
        public double Frequency { get => this.frequency; set => this.frequency = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Brand} CPU:");
            result.AppendLine($"Cores: {this.Cores}");
            result.AppendLine($"Frequency: {this.Frequency:F1} GHz");

            return result.ToString().Trim();
        }
    }
}
