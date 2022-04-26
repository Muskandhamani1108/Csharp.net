

using System;
using System.Collections.Generic;
using System.Text;

namespace singleinhe1
{
    public class p1
    {
        public int n1 = 0, n2 = 1, n3, n;
        public void read()
        {
            Console.WriteLine("Enter the no:-");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class p2 : p1
    {
        public void display()
        {
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < n; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            p2 p = new p2();
            p.read();
            p.display();
            Console.ReadLine();
        }
    }

}