using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class HashSet<T> : IEnumerable<T> where T : IComparable
    {
        private static readonly int DEFAULT_SIZE = 100;
        private static readonly double RATIO = 0.75;
        private ChainList<T>[] LinkedValues;
        public int Size;

        public HashSet()
        {
            this.LinkedValues = new ChainList<T>[DEFAULT_SIZE];
            this.Size = 0;
        }

        public void Add(T t)
        {
            if (!Contains(t))
            {
                // Check ratio with LinkedValues size
                int HashCode = t.GetHashCode();
                if ((double)LinkedValues.Length / Size > RATIO)
                {
                    // Rehash
                    this.ReHash();
                }
                else
                {
                    LinkedValues[this.GetHashCode(t)].Add(t);
                }
                this.Size++;
            }
        }

        public bool Contains(T t)
        {
            return LinkedValues[this.GetHashCode(t)].Contains(t);
        }

        private int GetHashCode(T t)
        {
            return t.GetHashCode() % LinkedValues.Length;
        }

        private void ReHash()
        {
            ChainList<T>[] ReHashedLinkedValues = new ChainList<T>[LinkedValues.Length * 2];

            foreach (ChainList<T> ChainValues in LinkedValues)
            {
                foreach (T Value in ChainValues)
                {

                }
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (ChainList<T> ChainValues in this.LinkedValues)
            {
                foreach (T Value in ChainValues)
                {
                    yield return Value;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
