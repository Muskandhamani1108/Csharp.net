using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    if (i >= 6)
                    {
                        Console.WriteLine(i);
                        continue;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}