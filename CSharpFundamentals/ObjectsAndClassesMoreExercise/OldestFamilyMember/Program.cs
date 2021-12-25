using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Family
    {
        public List<Person> familyMembers { get; set; }

        public Family()
        {
            this.familyMembers = new List<Person>(1);
        }

        public void AddMember(Person currentHuman)
        {
            this.familyMembers.Add(currentHuman);
        }

        public void GetOldestMember()
        {
            int age = int.MinValue;
            string oldestMember = string.Empty;

            foreach (var human in this.familyMembers)
            {
                if (human.age > age)
                {
                    oldestMember = human.name;
                    age = human.age;
                }
            }

            Console.WriteLine($"{oldestMember} {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();
            string[] userInput = new string[2];

            for (int i = 0; i < numberOfMembers; i++)
            {
                userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Person currentHuman = new Person(userInput[0], int.Parse(userInput[1]));

                
                family.AddMember(currentHuman);

            }

            family.GetOldestMember();
        }
    }
}
