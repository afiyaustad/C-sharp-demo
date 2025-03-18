using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal;
namespace AccessSpecifiers
{
    public class ABCD
    {
        private int a=1;
        public void seta(int k)
        {
            a = k;
        }
        public int geta() { return a; }
        public int b=2;
        protected int c=3;

    }
    class Program :Class1 // ABCD
    {
        static void Main(string[] args)
        {
            ABCD obj=new ABCD();
            Program pp=new Program();
            Console.WriteLine($"{obj.b}");
            //Console.WriteLine($"{pp.c}");
            //Console.WriteLine($"{pp.b}");
             obj.seta(1);
            Console.WriteLine($"{obj.geta()}");
            Console.WriteLine($"{pp.p}");
            Console.ReadLine();
        }
    }
}
