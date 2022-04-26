
using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
    class c1
    {
        public int a;
        public void read()
        {
            Console.WriteLine("Enter the no:-");
            a = Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("Square of " + a + " is " + a * a);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            c1 c = new c1();
            c.read();
            c.show();
            Console.ReadLine();

        }
    }
}