using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ILieutenantGeneral : IPrivate
    {
        public List<Private> Privates { get; set; }
    }
}
