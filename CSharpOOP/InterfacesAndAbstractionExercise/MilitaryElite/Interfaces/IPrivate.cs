using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface IPrivate : ISoldier
    {
        public decimal Salary { get; set; }
    }
}
