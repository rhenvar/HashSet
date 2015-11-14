using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class ChainList<T> : IEnumerable<T> where T : IComparable
    {
        private ChainNode<T> Head;

        public ChainList()
        {
            this.Head = null;
        }

        public void Add(T t)
        {
            if (Head == null)
            {
                this.Head = new ChainNode<T>(t);
            }
            else
            {
                ChainNode<T> Temp = Head;
                while (Temp.Next != null)
                {
                    Temp = Temp.Next;
                }
                Temp.Next = new ChainNode<T>(t);
            }
        }

        public bool Contains(T t)
        {
            foreach (T value in this)
            {
                if (t.CompareTo(t) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ChainNode<T> Temp = Head;
            
            while (Temp != null)
            {
                yield return Temp.Value;
                Temp = Temp.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
