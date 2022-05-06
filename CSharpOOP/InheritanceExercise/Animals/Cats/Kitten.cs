using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Cats
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender)
                : base(name, age, gender) { }        
        
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
