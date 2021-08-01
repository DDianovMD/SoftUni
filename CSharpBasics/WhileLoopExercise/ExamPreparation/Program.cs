using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekGrades = int.Parse(Console.ReadLine());
            int weekGradesCounter = 0;
            int numberOfTasks = 0;
            double gradesSum = 0;
            string taskName = "";
            string lastTask = "";

            while (taskName != "Enough")
            {
                taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    break;
                }
                numberOfTasks += 1;
                lastTask = taskName;
                int grade = int.Parse(Console.ReadLine());
                gradesSum += grade;
                if (grade <= 4)
                {
                    weekGradesCounter += 1;
                    if (weekGradesCounter == weekGrades)
                    {
                        Console.WriteLine($"You need a break, {weekGradesCounter} poor grades.");
                        break;
                    }
                }
            }

            if (taskName == "Enough")
            {
                double averageScore = gradesSum / numberOfTasks;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {numberOfTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}