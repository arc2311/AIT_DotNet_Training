using System;

namespace AccessSpecifier4
{
    public class Test3
    {
        protected internal long ln=123478L;

        protected internal void PrintLong()
        {
            Console.WriteLine(ln);
        }

    }
}