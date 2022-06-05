using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ISpy : ISoldier
    {
        public int CodeNumber { get; set; }
    }
}
