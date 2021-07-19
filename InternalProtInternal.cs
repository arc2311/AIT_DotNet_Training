using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Test1
    {
        internal int a = 10;
        protected internal string s = "pritam";
    }
   public class Test2:Test1
    {
        public void show()
        {
            Console.WriteLine("a:"+a);
            Console.WriteLine("s:" + s);
        }
    }

    class InternalProtInternal
    {
    }
}
