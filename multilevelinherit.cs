using System;
using System.Collections.Generic;
using System.Text;

namespace multilevelinhe
{
    class stud
    {
        public string name = "Deevya";
        public string class1 = "SYBCA";
    }
    class exam : stud
    {
        public string sub = "C#.net";
    }
    class result : exam
    {
        public int marks = 90;

        static void Main(string[] args)
        {
            result r1 = new result();
            Console.WriteLine("NAME:- " + r1.name);
            Console.WriteLine("CLASS:- " + r1.class1);
            Console.WriteLine("SUBJECT:- " + r1.sub);
            Console.WriteLine("MARKS:- " + r1.marks);
            Console.ReadLine();
        }
    }
}
