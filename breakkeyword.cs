using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}