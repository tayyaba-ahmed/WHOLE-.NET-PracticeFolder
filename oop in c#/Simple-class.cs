using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    internal class Simple_class //assume student class
    {
        private  int rollno;
        private string name;
        void Accept(int r, string n)
        {
            this.rollno = r;
            this.name = n;
        }
        void Display()
        {
            Console.WriteLine("rno is {0} and name is {1}", rollno, name);
        }
        public static void Main()
        {
            Simple_class student1 = new Simple_class();
            student1.Accept(009, "Tayyaba");
            student1.Display();
            Simple_class student2 = new Simple_class();
            student2.Accept(001, "Javeria");
            student2.Display();
        }
    }
}
