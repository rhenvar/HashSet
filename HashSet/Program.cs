using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainList<int> test = new ChainList<int>();
            for (int i = 0; i < 10; i++)
            {
                test.Add(i);
            }

            foreach (int i in test)
            {
                Console.WriteLine(i);
            }
        }
    }
}
