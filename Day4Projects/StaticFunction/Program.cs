using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFunction
{

    /*
    //non static to non static 
    class abcd
    {
        int a = 1;
        public void count()
        {
            a = a + 1;
            Console.WriteLine($"The value is :{a}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            abcd obj = new abcd();
            obj.count();
            obj.count();
            Console.ReadLine();
        }
    }*/
    //    static to static within the class direcly i can use
    //static to static outisde the classs use class name
    class abcd
    { 
        int a = 1;
    static public void count()
    {
        abcd obj = new abcd();  // here also as non static is coming in static
        obj.a = obj.a + 1;
        Console.WriteLine($"The value is :{obj.a}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        abcd obj = new abcd();
        abcd.count();// class name 
        abcd.count();// class name 
        Console.ReadLine();

    }
}
}
