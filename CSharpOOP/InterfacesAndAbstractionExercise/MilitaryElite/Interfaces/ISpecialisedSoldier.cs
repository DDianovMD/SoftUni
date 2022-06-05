using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ISpecialisedSoldier : IPrivate
    {
        public string Corp { get; set; }        
    }
}
