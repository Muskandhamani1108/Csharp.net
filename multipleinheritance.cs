using System;
using System.Collections.Generic;
using System.Text;

namespace multipleinhe
{
    class stud
    {
        public string name;
        public string class1;
        public void read()
        {
            Console.WriteLine("Enter your Name:-");
            name = Console.ReadLine();
            Console.WriteLine("Enter Class:-");
            class1 = Console.ReadLine();
        }
    }
    public interface exam
    {
        void showinfo();
    }
    class result : stud, exam
    {
        public int marks;
        public void showinfo()
        {
            Console.WriteLine("Enter your Marks:-");
            marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NAME:- " + name);
            Console.WriteLine("CLASS:- " + class1);
            Console.WriteLine("MARKS:- " + marks);
        }
        static void Main(string[] args)
        {
            result r1 = new result();
            r1.read();
            r1.showinfo();
            Console.ReadLine();
        }
    }
}
