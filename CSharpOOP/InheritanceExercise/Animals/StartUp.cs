using System;
using System.Collections.Generic;
using Animals.Cats;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] currentAnimal = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string animalName = currentAnimal[0];
                int animalAge = int.Parse(currentAnimal[1]);
                string animalGender = currentAnimal[2];

                if (animalAge < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                Animal animal = default;

                if (animalType == "Cat")
                {
                    animal = new Cat(animalName, animalAge, animalGender);
                }
                else if (animalType == "Dog")
                {
                    animal = new Dog(animalName, animalAge, animalGender);
                }
                else if (animalType == "Frog")
                {
                    animal = new Frog(animalName, animalAge, animalGender);
                }
                else if (animalType == "Kitten")
                {
                    animal = new Kitten(animalName, animalAge, "Female");
                }
                else if (animalType == "Tomcat")
                {
                    animal = new Tomcat(animalName, animalAge, "Male");
                }

                Console.WriteLine(animalType);
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
