using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class TaskEx
    {
        public void show() 
        {
            int a=10, b=5, c;
            try
            {

                c = a / b;
                try
                {


                    int[] arr = new int[3];
                    arr[3] = 10;
                    int[] arr1 = null;

                    foreach (int i in arr1)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                catch (IndexOutOfRangeException io)
                {
                    Console.WriteLine(io.Message);
                }
            
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            finally
            {
                Console.WriteLine("finally is executed");
            }

         }
    }
    class ExceptionEx
    {
        static void Main(string[] args)
        {
            TaskEx t = new TaskEx();
            t.show();
        }
    }
}
