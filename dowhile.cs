
using System;
using System.Collections.Generic;
using System.Text;
namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            Console.Write("***** INPUT ***** \n\n");
            Console.Write("Enter the no:- \n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("***** OUTPUT ***** \n");
            Console.Write("***** Do-While Loop Execution ***** \n");
            do
            {
                Console.Write(i * n + "\n");
                i++;
            }
            while (i <= 10);
        }
        Console.ReadLine();
    }
}