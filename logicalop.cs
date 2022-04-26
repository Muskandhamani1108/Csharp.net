using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicalop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Voters Selection***\n");
            int a;
            Console.WriteLine("Enter your age:-");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting, Sorry...");
            }
            Console.ReadLine();
        }
    }
}