using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> FamilyMembers { get; set; }

        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        // Methods

        public void AddMember(Person person)
        {
            FamilyMembers.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = FamilyMembers.OrderByDescending(x => x.Age).FirstOrDefault();

            return person;
        }
    }
}
