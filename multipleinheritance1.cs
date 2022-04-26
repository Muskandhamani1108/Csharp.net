using System;
using System.Collections.Generic;
using System.Text;

namespace multipleinterface
{
    class stud
    {
        public int n;
        public void read()
        {
            Console.WriteLine("Enter the number:-");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
    public interface exam
    {
        void show();
    }
    class result : stud, exam
    {
        public int i;
        public void show()
        {
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            result r1 = new result();
            r1.read();
            r1.show();
            Console.ReadLine();
        }
    }
}