using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public delegate void caldelegate (int a, int b);
    class DelegateExample
    {
        static void Main(string[] args)
        {
            //DelegateExample d = new DelegateExample();
            DelExample d1 = new DelExample();
            caldelegate cd = new caldelegate(d1.add);
            caldelegate cd1 = d1.sub;
            caldelegate cd2 = d1.mul;
            caldelegate cd3 = d1.div;
            caldelegate cdd = cd + cd1 + cd2 + cd3;
            Console.WriteLine(cdd);
            cdd.Invoke(10, 20);
;            



        }
    }
    class DelExample
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}