using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int studentsPerHour = employee1 + employee2 + employee3;
            int hoursCounter = 0;
            int cycles = 0;

            while (studentsCount > 0)
            {
                studentsCount -= studentsPerHour;
                hoursCounter++;
                cycles++;

                if (cycles % 3 == 0 && studentsCount > 0)
                {
                    hoursCounter++;
                    cycles = 0;
                }
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
