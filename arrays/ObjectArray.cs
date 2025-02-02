using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class ObjectArray
    {
        public static void Main()
        {
            // in object array you can give diff type of datatype values
            object [] arr = { 'C', 1, true, "Tayyaba", 12.32};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //foreach
            foreach (object o in arr) {
                Console.WriteLine(o);
            }
        }
    }
}
