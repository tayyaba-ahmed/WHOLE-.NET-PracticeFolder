using System;
class Boxing {
    public static void Main() {
        int a = 10, b;
        object o;
        o=a; // boxing - converting value of value type 
        // (primitve type which is int) into refrence type (derived type which is object)
        Console.WriteLine(o);
        b=(int)o; // unboxing - converting value of refrence type
        // type (derived type which is object) into value type (primitve type which is int)
        Console.WriteLine(b);
    }
}
// primitive type = int,char,float,double,bool,string (small s)
// derived type = it is for object oriented programming
// e.g of derived type = object, String (capital s), structure, class