using System;
using System.Collections.Generic;
using System.Linq;

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

namespace Students2._0
{
    class Program
    {
		static void Main(string[] args)
		{
			List<Students> students = new List<Students>();

			string[] userInput = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			while (userInput[0].ToLower() != "end")
			{
				bool isExisting = false;

				if (students.Count == 0)
				{
					Students student = new Students(userInput[0], userInput[1], int.Parse(userInput[2]), userInput[3]);
					students.Add(student);
				}
				else if (students.Count != 0)
				{
					foreach (var st in students)
					{
						if (st.firstName == userInput[0] && st.lastName == userInput[1])
						{
							st.age = int.Parse(userInput[2]);
							st.homeTown = userInput[3];
							isExisting = true;
						}
					}

					if (isExisting == false)
					{
						Students student = new Students(userInput[0], userInput[1], int.Parse(userInput[2]), userInput[3]);
						students.Add(student);
					}
				}

				userInput = Console.ReadLine()
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
