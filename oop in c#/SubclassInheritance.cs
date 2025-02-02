using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    // derived class
    internal class SubclassInheritance:Inheritance
    {
        // isme inheritance class ki id name wgrh bhe aachuki he
        // internal class ek program pr available hta
        int salary;
        // func internal isilye bnaye taake wo program k dsre files me available ho
        internal void accept1(int salary)
        {
            this.salary = salary;  
        }
        internal void display1()
        {
            Console.WriteLine("salary is {0}", salary);
        }
    }
}
