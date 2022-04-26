using System;
using System.Collections.Generic;
using System.Text;

namespace addarrayele
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            Console.WriteLine("Enter the size of array:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] n = new int[size];
            Console.WriteLine("Enter array elements:-");
            for (int i = 0; i < size; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(".....Array.....");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.WriteLine(".....Addition of array elements.....");
            for (int i = 0; i < size; i++)
            {
                add = add + n[i];
            }
            Console.WriteLine(add);
            Console.ReadLine();
        }
    }
}