using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class MethodOverloding
    {
        public void Add(int a, float b)
        {
            Console.WriteLine(a + b);

        }
        public int Add(int a, int b)
        {
            /*int result = a + b;
           Console.WriteLine(result);
            return result;*/
            return a + b;
        }
        public static void Main(string[] args)
        {
            MethodOverloding obj = new MethodOverloding();
            // obj.Add(10, 20)
            Console.WriteLine(obj.Add(10, 10));
            obj.Add(10, 20.86f);

        }
    }
}
