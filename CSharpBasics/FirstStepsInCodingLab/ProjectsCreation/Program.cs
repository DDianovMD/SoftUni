using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int neededHours = numberOfProjects * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", architectName, neededHours, numberOfProjects);

        }
    }
}