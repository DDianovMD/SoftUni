using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToLower() != "end")
            {
                Person currentPerson = new Person(command[0], int.Parse(command[1]), command[2]);
                people.Add(currentPerson);

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            int personPosition = int.Parse(Console.ReadLine());

            int matchesCounter = 0;
            int nonMatchesCounter = 0;
            int totalNumberOfPeople = people.Count;

            for (int i = 0; i < totalNumberOfPeople; i++)
            {

                int result = people[i].CompareTo(people[personPosition - 1]);

                if (result == 0)
                {
                    matchesCounter++;
                }
                else
                {
                    nonMatchesCounter++;
                }

            }

            if (matchesCounter >= 2)
            {
                Console.WriteLine($"{matchesCounter} {nonMatchesCounter} {totalNumberOfPeople}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
