using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class MyCustumTupleClass<T1, T2>
    {
        public Item1<T1> FirstItem { get; set; }

        public Item2<T2> SecondItem { get; set; }

        public MyCustumTupleClass(T1 item1, T2 item2)
        {
            Item1<T1> firstItem = new Item1<T1>(item1);
            Item2<T2> secondItem = new Item2<T2>(item2);

            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }
    }
}
