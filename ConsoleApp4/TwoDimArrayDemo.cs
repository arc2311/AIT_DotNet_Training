using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class TwoDimArrayDemo
    {
      //  public void IntTwoDArry()
      static void Main(string[] args)
        {
            //int[,] iarr = new int[3, 3];

            //for(int i=0;i<3;i++)
            //{
            //    for(int j=0;j<3;j++)
            //    {
            //        iarr[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for(int i=0;i<3;i++)
            //{
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.WriteLine(iarr[i, j]);
            //    }
            //}

            MatrixAddition m = new MatrixAddition();
            m.MatrixAdd();
            m.MatrixMul();

            string s = Console.ReadLine();

        }
    }
}
