using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public void PrefixPostfix()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine(a);    //10
            Console.WriteLine(b);   //20
            a++;
            Console.WriteLine(a);   //11
                                    //++a;
            Console.WriteLine(++a); //12
            Console.WriteLine(a++); //12
            Console.WriteLine(a);   //13
            Console.WriteLine(b--); //20
            Console.WriteLine(b);   //19
            Console.WriteLine(--b); //18
        }
        
    }
}
