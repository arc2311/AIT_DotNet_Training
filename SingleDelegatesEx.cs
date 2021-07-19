using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class SingleDelegatesEx
    {
        public delegate void singledelegate(int a, int b);
        class singleDel
        {
            public void add(int a,int b)
            {
                Console.WriteLine("sum is:" + (a + b));
            }
        }
        static void Main(string[] args)
        {
            singleDel s = new singleDel();
            singledelegate sd = new singledelegate(s.add);
            sd(20, 30);

        }
    }
}
