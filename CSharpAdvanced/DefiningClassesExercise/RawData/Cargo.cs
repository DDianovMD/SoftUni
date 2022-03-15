using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }

        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
