using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first no:-");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no:-");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Addition is:-" + c);
            int d = a - b;
            Console.WriteLine("substraction is:-" + d);
            int e = a * b;
            Console.WriteLine("Multiplication is:-" + e);
            int f = a / b;
            Console.WriteLine("Division is:-" + f);
            int g = a % b;
            Console.WriteLine("Modulo is:-" + g);
            Console.ReadLine();
        }
    }
}