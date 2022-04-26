using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Check the Result **** \n");
            Console.WriteLine("Enter the Percentage:- ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p >= 70 && p <= 100)
            {
                Console.WriteLine("You are in  Distinction");
            }
            else if (p >= 60 && p < 70)
            {
                Console.WriteLine("You got First class");
            }
            else if (p >= 40 && p < 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();
        }
    }
}