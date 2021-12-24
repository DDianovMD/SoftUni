using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    public class Person
    {
        public string name { get; set; }
        public int personID { get; set; }
        public int age { get; set; }

        public Person(string name, int personID, int age)
        {
            this.name = name;
            this.personID = personID;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] userInput = new string[3];

            bool keepGoing = true; // flag

            while (keepGoing)
            {
                bool receivedAlready = false;

                userInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (userInput[0].ToLower() == "end")
                {
                    keepGoing = false;
                    break;
                }

                Person currentPerson = new Person(userInput[0], int.Parse(userInput[1]), int.Parse(userInput[2]));

                if (people.Count() == 0)
                {
                    people.Add(currentPerson);
                }
                else
                {
                    for (int i = 0; i < people.Count(); i++)
                    {
                        if (people.ElementAt(i).personID == int.Parse(userInput[1]))
                        {
                            people.ElementAt(i).name = userInput[0];
                            people.ElementAt(i).age = int.Parse(userInput[2]);
                            receivedAlready = true;
                            break;
                        }
                    }

                    if (receivedAlready == false)
                    {
                        people.Add(currentPerson);
                    }
                }
            }

            foreach (var person in people.OrderBy(x => x.age))
            {
                Console.WriteLine($"{person.name} with ID: {person.personID} is {person.age} years old.");
            }
        }
    }
}
