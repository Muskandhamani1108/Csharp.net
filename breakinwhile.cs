using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    if (i == 6)
                    {
                        break;
                    }
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}