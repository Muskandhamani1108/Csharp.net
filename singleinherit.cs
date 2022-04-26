
using System;
using System.Collections.Generic;
using System.Text;

namespace singleinheritance
{
    public class f1
    {
        public int n, fact = 1;
        public void read()
        {
            Console.WriteLine("Enter the no:-");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class f2 : f1
    {
        int i;
        public void cal()
        {
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
        }
        public void show()
        {
            Console.WriteLine("Factorial of " + n + " is " + fact);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            f2 f = new f2();
            f.read();
            f.cal();
            f.show();
            Console.ReadLine();
        }
    }
}
