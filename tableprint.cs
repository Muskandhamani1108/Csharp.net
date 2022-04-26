
using System;
using System.Collections.Generic;
using System.Text;
namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("***** INPUT *****\n \n");
            Console.Write("Enter the no to print the table:- \n\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("      ***** OUTPUT *****        \n");
            Console.Write("***** For Loop Execution *****\n\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write(i * n + "\n");
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}