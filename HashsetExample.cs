using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class HashsetExample
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Parbhani");
            names.Add("Nanded");
            names.Add("Latur");
            names.Add("Pune");
            names.Add("Mumbai");
            names.Add("Hyderabad");

            IEnumerator ie = names.GetEnumerator();
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }


        }

    }
}
