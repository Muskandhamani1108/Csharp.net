/*
    Que:-Demonstrate use of class and object.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace classobj
{
    public class demo
    {
        public int r;
        public string n;
        public void read()
        {
            Console.WriteLine("Enter roll no:-");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:-");
            n = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine("Your Rollno is:- " + r);
            Console.WriteLine("Your Name is:-" + n);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            demo d1 = new demo();
            d1.read();
            d1.show();
            Console.ReadLine();
        }
    }
}