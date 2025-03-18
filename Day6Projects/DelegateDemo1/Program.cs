using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemo1.Program;

namespace DelegateDemo1
{
    internal class Program
    {
        public static void add(int x,int y)
        {
            Console.WriteLine($"the sum is {x + y}");
        }
        public static int sub(int x, int y)
        {
            return x - y;

        }

        public static int multi(int x, int y)
        {
            return x * y;
        }

        public delegate void mydelegate(int x, int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {
            // add(12, 34);complie time not needed 
            mydelegate mm = add;
            mm(12, 4);// excutinng the deegate 
            mydelegate mm2 = add;
            mm2.Invoke(12, 6);
            //mm = sub; errro because return type not mathing with delegate
            mydelegate2 mm3 = sub;
            Console.WriteLine($"substarct: {mm3(12, 3)}");

             //multi cast delegate i want to do 
            mm3 += multi;
            Console.WriteLine($"multiply: {mm3(12, 3)}");
            ; Console.ReadLine();
        }
    }
}
