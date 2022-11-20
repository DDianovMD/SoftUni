using System;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (value != null && value != string.Empty)
                {
                    name = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        
        public int Age
        {
            get
            {
                return age;
            }

            private set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public virtual string Gender
        {
            get
            {
                return gender;
            }
            private set
            {
                if (value == "Male" || value == "Female")
                {
                    gender = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

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
