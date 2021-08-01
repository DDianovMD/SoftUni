using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            
            if (capacity >= numberOfPeople)
            {
                Console.WriteLine(1);
            }
            else if (capacity < numberOfPeople)
            {
                if (numberOfPeople % capacity != 0)
                {
                    int courses = numberOfPeople / capacity + 1;
                    Console.WriteLine(courses);
                }
                else
                {
                    Console.WriteLine(numberOfPeople / capacity);
                }
            }           
        }
    }
}