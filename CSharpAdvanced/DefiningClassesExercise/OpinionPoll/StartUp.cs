using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] userInput = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person currentPerson = new Person(userInput[0], int.Parse(userInput[1]));

                family.AddMember(currentPerson);
            }

            foreach (var person in family.FamilyMembers.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
