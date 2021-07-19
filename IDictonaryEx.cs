using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Collection
{
    class IDictonaryEx
    {
        public static void PrintValues(IDictionary<int,int> dict)
        {
            // start with capital I is interface
            IEnumerator z = dict.GetEnumerator();
            while (z.MoveNext())
            {
                Console.WriteLine(z.Current);
            }
        }
        static void Main()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(1, 189);
            dict.Add(2, 145);
            dict.Add(3, 178);
            dict.Add(4, 199);
            dict.Add(5, 123);
            dict.Add(6, 156);
            dict.Add(7, 166);
            dict.Add(8, 185);
            List<int> l = new List<int>(dict.Keys);
            /*foreach (int res in l)
            {
                Console.WriteLine("{0}, {1}", res, dict[res]);
            }*/
            IDictonaryEx.PrintValues(dict);

        }
    }
}