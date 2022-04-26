using System;
using System.Collections.Generic;
using System.Text;

namespace pconstructor
{
    class cons
    {
        int age;
        string name;
        public cons(int a, string n)
        {
            age = a;
            name = n;
            Console.WriteLine("Roll No:-" + a);
            Console.WriteLine("Name:-" + n);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            cons c1 = new cons(18, "Tejaswini");

            Console.ReadLine();
        }
    }
}