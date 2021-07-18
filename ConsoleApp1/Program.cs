using System;

namespace ConsoleApp1
{
    class Program
    {

        int gl = 20; //global scope

        //Primitive data Type
        public void DataType()
        {
            char ch = 'A';
            int i = 100;
            uint ui = 50;
            float fl = 10.2f;
            bool boolVar = true;
            long l = 1908765L;
            ulong ul = 23456789L;
            double d = 123.5677d;
            byte b = 1;
            short s = 2;

            Console.WriteLine("Value of ch : " + ch);
            Console.WriteLine("Value of i : " + i);
            Console.WriteLine("Value of ui : " + ui);
            Console.WriteLine("Value of f : " + fl);
            Console.WriteLine("Value of bool : " + boolVar);
            Console.WriteLine("Value of Long : " + l);
            Console.WriteLine("Value of ulong : " + ul);
            Console.WriteLine("Value of double : " + d);
            Console.WriteLine("Value of byte : " + b);
            Console.WriteLine("Value of short : " + s);
        }




        struct MyStruct
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! 45");
            int gl = 10;//local scope

            Console.WriteLine(gl);
            int aInt = 23;
            float bFloat = aInt;//implicit type cast no data loss
            Console.WriteLine(bFloat);

            float f = 23.4f;
            int i = (int)f;//explicity type cast data loss
            Console.WriteLine(i);
            //   Class1 c = new Class1();
            //c.TypeCast();


            //Boxing and unboxing examples

            int i1 = 45;
            Object obj = i1;//Boxing

            Console.WriteLine(obj);

            int i2 = (int)obj;//unboxing

            Console.WriteLine(i2);


            MyStruct ms = new MyStruct();
            ms.x = 10;
            ms.y = 20;

            int sum = ms.x + ms.y;
            Console.WriteLine(sum);
            // Console.WriteLine("Value of X : " + ms.x);
            // Console.WriteLine("Value of y : " + ms.y);

            Program p = new Program();
            p.DataType();

            Class1 c = new Class1();
            c.PrefixPostfix();

        }
    }
}
