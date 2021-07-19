using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Vehicle
    {
        void Run(); 
    }
    class Car:Vehicle
    {
        public void Run()
        {
            Console.WriteLine("car is Running");
        }
    }
    class Bike : Vehicle
    {
        public void Run()
        {
            Console.WriteLine("Bike is Running");
        }
    }


   public class InterfaceExample
    {
       public static void Main(string[] args)
        {
            Vehicle v;
            v= new Car();
            v.Run();
            v = new Bike();
              v.Run();


        }


    }
}
