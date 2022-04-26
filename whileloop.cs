using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}