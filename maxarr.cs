using System;
using System.Collections.Generic;
using System.Text;

namespace array
{
    class Program
    {

        int i, mno = 0;
        int[] a = { 6, 3, 30, 2, 4 };
        void mno1()
        {
            for (i = 0; i < 4; i++)
            {
                if (a[i] > mno)
                {
                    mno = a[i];
                }
            }
            Console.WriteLine("Biggest element is:-" + mno);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.mno1();
            Console.ReadLine();
        }
    }
}