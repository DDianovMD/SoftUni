using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private int age;
        protected string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Gender { get; set; }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Gender}";
        }
    }
}
