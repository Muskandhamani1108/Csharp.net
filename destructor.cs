using System;
using System.Collections.Generic;
using System.Text;

namespace tablecons
{
    class cons
    {
        public cons(int n)
        {
            Console.WriteLine("Table of " + n + " is:-");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * n);
            }
        }
        ~cons()
        {
            Console.WriteLine("Destructor is called.....");
            Console.ReadLine();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the no:- ");
            n = Convert.ToInt16(Console.ReadLine());
            cons c1 = new cons(n);
            Console.ReadLine();
        }
    }
}