using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> internalList { get; set; } = new List<T>();
        public int Count { get => internalList.Count; }
        public void Add(T element)
        {
            internalList.Add(element);
        }

        public T Remove()
        {
            T element = internalList[internalList.Count - 1];
            internalList.RemoveAt(internalList.Count - 1);

            return element;
        }
    }
}
