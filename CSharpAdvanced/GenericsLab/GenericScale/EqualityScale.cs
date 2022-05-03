namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T Left { get => this.left; set => this.left = value; }
        public T Right { get => this.right; set => this.right = value; }

        public bool AreEqual()
        {
            return this.left.Equals(this.right);
        }
        
    }
}
