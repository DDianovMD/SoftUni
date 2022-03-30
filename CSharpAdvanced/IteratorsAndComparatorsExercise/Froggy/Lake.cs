using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private List<T> _stones;
        private List<T> evenStones;
        private List<T> oddStones;
        public Lake(IEnumerable<T> stones)
        {
            _stones = new List<T>(stones);
            evenStones = new List<T>();
            oddStones = new List<T>();

            for (int i = 0; i < _stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenStones.Add(_stones[i]);
                }
                else
                {
                    oddStones.Add(_stones[i]);
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in evenStones)
            {
                yield return item;
            }

            oddStones.Reverse();

            foreach (var item in oddStones)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
