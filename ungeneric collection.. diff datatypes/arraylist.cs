using System.Collections;

namespace collection
{
    // array jesa hta but collection me size and datatypes ki
    // restriction nahi hoti
    internal class Arraylist
    {
        static void Main(string[] args)
        {
            // arraylist bani hui class hai
            // object (datatype dont matter) ka bana hwa array jisme size dont matter
            ArrayList obj = new ArrayList();    
            obj.Add(1); // add hota hai element
            obj.Add('C');
            obj.Add("Tayyaba");
            obj.Add(12.3);
            obj.Remove(1); // to remove an element
            foreach (object i in obj) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}
