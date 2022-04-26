using System;
using System.Collections.Generic;
using System.Text;

namespace dconstructor
{
    class cons
    {
        int age;
        public cons()
        {
            age = 18;
            Console.WriteLine(age);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            cons a = new cons();
            Console.ReadLine();
        }
    }
}