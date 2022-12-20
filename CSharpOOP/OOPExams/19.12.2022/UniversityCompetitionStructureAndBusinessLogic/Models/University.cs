using System;
using System.Collections.Generic;

using UniversityCompetition.Models.Contracts;

namespace UniversityCompetition.Models
{
    public class University : IUniversity
    {
        private int id;
        private string name;
        private string category;
        private int capacity;
        private List<int> requiredSubjects = new List<int>();

        public University(int universityId,
                          string universityName,
                          string category,
                          int capacity,
                          ICollection<int> requiredSubjects)
        {
            Id = universityId;
            Name = universityName;
            Category = category;
            Capacity = capacity;

            foreach (int item in requiredSubjects)
            {
                this.requiredSubjects.Add(item);
            }
        }

        public int Id
        {
            get => this.id;
            private set => this.id = value;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                this.name = value;
            }
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                if (value != "Technical" && value != "Economical" && value != "Humanity")
                {
                    throw new ArgumentException($"University category {value} is not allowed in the application!");
                }

                this.category = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("University capacity cannot be a negative value!");
                }

                this.capacity = value;
            }
        }

        public IReadOnlyCollection<int> RequiredSubjects => this.requiredSubjects.AsReadOnly();
    }
}
