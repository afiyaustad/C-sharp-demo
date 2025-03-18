using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printandscandemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter Values in x and y...");
            x = Convert.ToInt32(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("the sum of {0} and {1} is {2}", x, y, z); 
            Console.WriteLine("sum of " + x + " and " + y + " is " + z);
            Console.WriteLine($"sum of {x} and {y} is {z}");
            Console.WriteLine("The sum of {0,8} and {1,6} is {2,7}", x, y, z);



            //printing constants 
            Console.WriteLine("priniting constant value without keeping inside variable:{0}", 34.56);
            Console.WriteLine($"Febuary has either {28} or {29}");


            // taking value in a single line 
            Console.WriteLine("\nenter values in a a single line ");
            string input = Console.ReadLine();
            int m, n;
            m = Convert.ToInt32(input.Split(',')[0]);
            n = Convert.ToInt32(input.Split(',')[1]);
            Console.WriteLine($"The sum of {m} and {n} is {m + n}");


            // taking values in a single line but choose the deleimiter
            Console.WriteLine("\nenter values in a single line but choose the deleimiter ...");
            char[] chars = new char[] { ',', '-', '_', '.', '$' };

            string input2 = Console.ReadLine();
            int m1, n1;
            m1 = Convert.ToInt32(input2.Split(chars)[0]);
            n1 = Convert.ToInt32(input2.Split(chars)[1]);
            Console.WriteLine($"The sum of {m1} and {n1} is {m1 + n1}");


            //MaxValue and MinValue of Datatypes
            Console.WriteLine($"Int max value and min value is {int.MaxValue} and {int.MinValue}");

            Console.WriteLine($"Byte max value and min value is {Byte.MaxValue} and {Byte.MinValue}");

            Console.WriteLine($"decimal max value and min value is {decimal.MaxValue} and {decimal.MinValue}\n");

            // some more daat types how to declare what convention to use 

            decimal kk = 456.67M;
            float ss = 12.45F;
            string name = "sudha";
            char ch = 'A';
            Console.WriteLine($"{kk}--{ss}--{name}--{ch}");

            Console.ReadLine();
        }
    }
}