using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        private string model;
        private int capacity;

        public Computer(string model, int capcity)
        {
            this.Multiprocessor = new List<CPU>();
            this.Model = model;
            this.Capacity = capcity;
        }

        public string Model { get => this.model; set => this.model = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int Count { get => this.Multiprocessor.Count; }
        public List<CPU> Multiprocessor { get => this.multiprocessor; set => this.multiprocessor = value; }

        public void Add(CPU cpu)
        {
            if (this.Count < this.Capacity)
            {
                this.Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            int removedCount = this.multiprocessor.RemoveAll(cpu => cpu.Brand == brand);

            if (removedCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public CPU MostPowerful()
        {
            CPU mostPowerfulCPU = this.Multiprocessor.OrderByDescending(cpu => cpu.Frequency).ElementAt(0);

            return mostPowerfulCPU;
        }

        public CPU GetCPU(string brand)
        {
            CPU result = this.Multiprocessor.FirstOrDefault(cpu => cpu.Brand == brand);

            return result;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"CPUs in the Computer {this.Model}:");
            foreach (var cpu in this.Multiprocessor)
            {
                result.AppendLine(cpu.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
