using System;
using System.Collections.Generic;
using System.Linq;


namespace Students
{
	public class Student
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public double grade { get; set; }

		public Student(string firstName, string lastName, double grade)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.grade = grade;
		}

	}

	class Program
    {
        static void Main(string[] args)
        {
			int studentsCount = int.Parse(Console.ReadLine());

			List<Student> studentsList = new List<Student>();

			for (int i = 0; i < studentsCount; i++)
			{
				string[] userInput = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				Student currentStudent = new Student(userInput[0], userInput[1], double.Parse(userInput[2]));

				studentsList.Add(currentStudent);
			}

			foreach (var student in studentsList.OrderByDescending(x => x.grade))
			{
				Console.WriteLine($"{student.firstName} {student.lastName}: {student.grade:F2}");
			}
		}
    }
}
