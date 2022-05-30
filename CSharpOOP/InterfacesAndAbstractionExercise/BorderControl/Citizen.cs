using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string iD)
        {
            Name = name;
            Age = age;
            ID = iD;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string ID { get; set; }
    }
}
