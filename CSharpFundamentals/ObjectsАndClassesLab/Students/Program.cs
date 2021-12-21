using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
	public class Students
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public int age { get; set; }
		public string homeTown { get; set; }

		public Students(string firstName, string lastName, int age, string homeTown)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.homeTown = homeTown;
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			List<Students> students = new List<Students>();

			string[] command = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			while (command[0].ToLower() != "end")
			{
				Students student = new Students(command[0], command[1], int.Parse(command[2]), command[3]);

				students.Add(student);

				command = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			}

			string city = Console.ReadLine();

			foreach (var student in students)
			{
				if (city == student.homeTown)
				{
					Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
				}
			}
		}
    }
}
