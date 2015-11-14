using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class ChainNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public ChainNode<T> Next { get; set; }

        public ChainNode(T t)
        {
            this.Value = t;
        }
    }
}
