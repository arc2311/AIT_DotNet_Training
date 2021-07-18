using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 60;
            int c = 70;

            int total = a+b+c;

            float percentage = total * 100 / 300;

            if(percentage>=70)
            {
                Console.WriteLine("A");
            }
            else if(percentage<70 || percentage>=60)
            {
                Console.WriteLine("B");
            }
            else if(percentage<60 || percentage>=50)
            {
                Console.WriteLine("c");

            }
            else if(percentage<50 || percentage>=40)
            {
                Console.WriteLine("Pass");

            }
            else
            {
                Console.WriteLine("Fail");

            }


            for(int i=0;i<=10;i++)
            {
                if (i % 2 == 0) 
                continue;
                Console.WriteLine(i);
            }
            //goto Example

            show:
            Console.WriteLine("Monday");
            int day = 1;
            if(day==1)
            {
                goto show;
            }
            else
            {
                Console.WriteLine("Add Another day");


            }

            //nested if else
           int  num1 = 10;
           int  num2 = 20;
           int  num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest");
                }
                else
                {
                    Console.Write("Number three is the largest");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("Number two is the largest");
            }
            else
            {
                Console.Write("Number three is the largest!\n");
            }
        

        //For each example

        int [] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }



        }
    }
}
