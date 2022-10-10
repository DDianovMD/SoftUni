using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators = new List<Renovator>();

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count { get => this.renovators.Count; }

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public string AddRenovator(Renovator renovator)
        {
            if (this.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }

            if (renovator.Name == null || renovator.Name == string.Empty || renovator.Type == null || renovator.Type == string.Empty)
            {
               return "Invalid renovator's information.";
            }

            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            this.renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            bool result = this.renovators.Any(renovator => renovator.Name == name);

            if (result)
            {
                this.renovators.RemoveAll(renovator => renovator.Name == name);
            }

            return result;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            return this.renovators.RemoveAll(renovator => renovator.Type == type);
        }

        public Renovator HireRenovator(string name)
        {
            if (this.renovators.Any(renovator => renovator.Name == name))
            {
                for (int i = 0; i < this.renovators.Count; i++)
                {
                    if (this.renovators[i].Name == name)
                    {
                        this.renovators[i].Hired = true;
                        break;
                    }
                }

                return this.renovators.Where(renovator => renovator.Name == name).ElementAt(0);
            }
            else
            {
                return null;
            }
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> result = new List<Renovator>();

            foreach (var renovator in this.renovators.Where(renovator => renovator.Days >= days))
            {
                result.Add(renovator);
            }

            return result;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Renovators available for Project {this.Project}:");
            foreach (var renovator in this.renovators.Where(renovator => renovator.Hired == false))
            {
                stringBuilder.AppendLine(renovator.ToString());
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
