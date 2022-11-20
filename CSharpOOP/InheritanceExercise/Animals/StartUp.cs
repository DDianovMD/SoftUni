using System;
using System.Collections.Generic;
using Animals.Cats;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

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

                try
                {
                    if (currentAnimal.Length < 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (animalType == "Cat")
                        {
                            Animal animal = new Cat(animalName, animalAge, animalGender);
                            animals.Add(animal);
                        }
                        else if (animalType == "Dog")
                        {
                            Animal animal = new Dog(animalName, animalAge, animalGender);
                            animals.Add(animal);
                        }
                        else if (animalType == "Frog")
                        {
                            Animal animal = new Frog(animalName, animalAge, animalGender);
                            animals.Add(animal);
                        }
                        else if (animalType == "Kitten")
                        {
                            Animal animal = new Kitten(animalName, animalAge);
                            animals.Add(animal);
                        }
                        else if (animalType == "Tomcat")
                        {
                            Animal animal = new Tomcat(animalName, animalAge);
                            animals.Add(animal);
                        }
                    }                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }                                    
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
