using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] userInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person currentPerson = new Person(userInput[0], userInput[1], int.Parse(userInput[2]));

                people.Add(currentPerson);
            }

            foreach (Person person in people.OrderBy(x => x.FirstName).ThenBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
}
