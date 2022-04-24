using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] userInput = Console.ReadLine()
                                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                string name = userInput[0];
                int personAge = int.Parse(userInput[1]);

                Person currentPerson = new Person(name, personAge);

                people.Add(currentPerson);
            }

            Action<string, int, string> printResultByCondition = (condition, age, printFormat) =>
            {
                List<Person> filteredByCondition = new List<Person>();

                if (condition == "older")
                {
                    filteredByCondition = people.FindAll(x => x.Age >= age);
                }
                else if (condition == "younger")
                {
                    filteredByCondition = people.FindAll(x => x.Age < age);
                }

                if (printFormat.Contains("name") && printFormat.Contains("age"))
                {
                    foreach (var person in filteredByCondition)
                    {
                        Console.WriteLine($"{person.Name} - {person.Age}");
                    }
                }
                else if (printFormat.Contains("name") && printFormat.Contains("age") == false)
                {
                    foreach (var person in filteredByCondition)
                    {
                        Console.WriteLine(person.Name);
                    }
                }
                else if (printFormat.Contains("age") && printFormat.Contains("name") == false)
                {
                    foreach (var person in filteredByCondition)
                    {
                        Console.WriteLine(person.Age);
                    }
                }
            };

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();

            printResultByCondition(condition, age, printFormat);
        }
    }
}
