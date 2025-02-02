using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Stack_and_queue
    {
        public static void Main(string[] args)
        {
            // stack bani hui class hai
            // stack is last in first out.. jo last me push 
            // kia wo sbse pehle print hoga
            Stack obj = new Stack();
            obj.Push(1); // add element
            obj.Push(2);
            obj.Push(3);
            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }

            //  queue bani hui class hai
            // stack is first in first out.. jo first add 
            // kia wo sbse pehle print hoga
            Queue obj1 = new Queue();
            obj1.Enqueue(1); // add element
            obj1.Enqueue(2);
            obj1.Enqueue(3);
            foreach (var i in obj1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
