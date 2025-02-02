using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_c_
{
    internal class Polymor_overloading
    {
        // ab tm add(int a,int b) bnati tw wo overloading ni hti.. ya tw
        // same datatype ho tw parameters add hngy ya diff datatypes ho tw same
        // number of parameters deskte hen.. tm bnaogi alg sy tw khudi error ajyega
        void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        //void add(int a, int b) { } ye error hi dega
        void add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        void add(float x, int y)
        {
            Console.WriteLine(x + y);
        }
        void add(int x, float y)
        {
            Console.WriteLine(x + y);
        }
        void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public static void Main() { 
            Polymor_overloading obj = new Polymor_overloading();
            obj.add(1,2,3); // ek h func call krna prega wo khudi apna type dhndh lega
        }
    }
}
