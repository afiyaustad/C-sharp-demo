using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInbuildFunction
{
    internal class Program
    {
        public static void add(int a, float b, decimal k)
        {
            Console.WriteLine($"The sum is:{a + Convert.ToDecimal(b) + k}");
        }

        public static double add(int a, decimal b, double kk)
        {
            return (a + Convert.ToDouble(b) + kk);

        }

        public static bool checklength(string str)
        {
            if (str.Length > 10)
                return true;
            else
                return false;
        }
        // public delegate void mydelegate1(int a,float b,decimal k);
        //  public delegate double mydelegate2(int a, decimal b, double kk);
        //   public delegate bool mydelegate3(string str);



        static void Main(string[] args)
        {
            Action<int, float, decimal> mm1 = add;
            mm1(12, 234.45F, 456.89M);

            Func<int, decimal, double, double> mm2 = add;
            Console.WriteLine($"The addition is:{mm2(12, 345.56M, 345.789)} ");

            Predicate<string> mm3 = checklength;
            Console.WriteLine($"The name is more than 10 characters :{mm3("Raghavendra")}");
            Console.ReadLine();

        }
    }
}
