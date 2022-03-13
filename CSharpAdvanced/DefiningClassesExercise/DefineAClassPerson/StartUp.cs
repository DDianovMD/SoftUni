using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 20;

            Person person1 = new Person();
            person1.Name = "George";
            person1.Age = 18;

            Person person2 = new Person();
            person2.Name = "Jose";
            person2.Age = 43;
        }
    }
}
