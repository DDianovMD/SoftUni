using System;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.age = age;
            this.name = "No name";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
