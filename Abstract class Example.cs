using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public abstract class Task1
    {
       public abstract void Show();
        
    }
    public class Task2:Task1
    {
        public override void Show()
        {
            Console.WriteLine("This is Task2 class");
        }
    }
    public class Task3 : Task1
    {
        public override void Show()
        {
            Console.WriteLine("This is Task3 class");
        }
    }
   public class Abstract_class_Example
    {
        static void Main(string[] args)
        {
            Task1 t ;
            t = new Task2();
            t.Show();
            t = new Task3();
            t.Show();

        }

    }
}
