using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Hash_table
    {
        public static void Main(string[] args)
        {
            // hashtable bani hui class hai
            // key or value jab use krna ho then use hashtable
            // hashtable me unsorted ata he
            // Hashtable obj = new Hashtable();

            // sortedlist bani hui class hai
            // key or value jab use krna ho then use sortedlist .. numeric keys hgi 
            // tou ascending order me ayega.. alphabetic me alphabetic order k a/c
            // keys ayegi
            // sortedlist me sorted ata he
            SortedList obj = new SortedList();

            obj.Add("name", "Tayyaba"); // add hota hai element
            obj.Add("age", 19);
            //obj.Remove("name"); to remove an element
            // dictionaryentry use krna prta for hashtable
            foreach (DictionaryEntry entry in obj)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }
        }
    }
}
