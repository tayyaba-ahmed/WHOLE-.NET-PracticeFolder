using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    internal class Encapsulation
    {
        // data members private krdie so they can only be accessed by
        // member functions or contrusctor is called encapsulation
        private int rollno;
        private string name;

        // default contructor
        Encapsulation()
        {
            rollno = 009;
            name = "Tayyaba";
        }

        // parametrized constructor .. isy call ni krte in main 
        Encapsulation(int r, string n)
        {
            this.rollno = r;
            this.name = n;
        }
        //void Accept(int r, string n)
        //{
        //    this.rollno = r;
        //    this.name = n;
        //}
        void Display()
        {
            Console.WriteLine("rno is {0} and name is {1}", rollno, name);
        }
        public static void Main()
        {
            // IT WILL CALL DEAFULT CONSTRUCTOR
            Encapsulation student1 = new Encapsulation();
            //student1.Accept(009, "Tayyaba");
            student1.Display();

            // IT WILL CALL PARAMETRIZED CONSTRUCTOR
            Encapsulation student2 = new Encapsulation(002,"Moazzama");
            //student1.Accept(001, "Javeria");
            student2.Display();
        }
    }
}
