using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    internal class SUBCLASS_subclassinheritance : SubclassInheritance
    {
        // isme inheritance class ki id name , subclassinhertance ki
        // salary wgrh bhe aachuki he
        // internal class ek program pr hr file mei available hta
        int role;
        internal void accept2(int role)
        {
            this.role = role;
        }
        internal void display2()
        {
            Console.WriteLine("role is {0}", role);
        }
    }
}
