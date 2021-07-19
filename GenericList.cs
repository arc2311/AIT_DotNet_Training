using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class GenericList
    {
        static void Main(string[] args)
        {
            List<String> l = new List<String>();
            l.Add("Archana");
            l.Add("Komal");
            l.Add("Tejal");
            l.Add("Sandhya");
            l.Add("Shweta");

            Console.WriteLine("Printed using foreach");
            foreach(string s in l)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine("Printed using for");
            for(int i=0;i<5;i++)
            {
            Console.WriteLine(l[i]);

            }
            Console.WriteLine("Printed using Enumerator");

            IEnumerator z = l.GetEnumerator();
            while (z.MoveNext())
            {
                Console.WriteLine(z.Current);
            }
            Console.WriteLine("Length of list");
            Console.WriteLine(l.Count);

            Console.WriteLine("Printed using Enumerable");

            IEnumerable<string> ie = (IEnumerable<string>)l;


            foreach (string e in ie)
            {
                Console.WriteLine(e);
            }

        }
    }
}
