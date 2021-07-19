using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericListEx
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(20);
            l.Add(30);
            l.Add(40);
            l.Add(50);
            l.Add(60);

            foreach (int list in l)
            {
                Console.WriteLine(list);
            }


        }
    }
}
