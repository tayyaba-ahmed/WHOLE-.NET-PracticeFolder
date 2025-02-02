using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    // main class
    internal class Inheritance
    {
        int id;
        string name;
        void accept(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        void display()
        {
            Console.WriteLine("id is {0} and name is {1}", id, name);
        }
        public static void Main()
        {
            Inheritance obj = new Inheritance();
            obj.accept(2, "tayyaba");
            obj.display();

            SubclassInheritance obj2 = new SubclassInheritance();
            obj2.accept(3, "tayyaba");
            obj2.display();
            obj2.accept1(1200);
            obj2.display1();

            SUBCLASS_subclassinheritance obj3 = new SUBCLASS_subclassinheritance();
            obj3.accept(4, "tayyaba");
            obj3.display();
            obj3.accept1(1300);
            obj3.display1();
            obj3.accept2(1);
            obj3.display2();
        }
    }
}
