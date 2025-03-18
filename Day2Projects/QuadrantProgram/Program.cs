using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrantProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the x and y coordinates:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\n The point ({x},{y}) lies in :");

            if (x == 0)
                if (y == 0)
                    Console.WriteLine("in origin");
                else
                    Console.WriteLine("in Y axis");
            else
                if (y == 0)
                Console.WriteLine("On x axis ");
            else
                if (x > 0)
                if (y > 0)
                    Console.WriteLine("First Quardarant");
                else
                    Console.WriteLine("foruth quardarant");
            else
                if (y > 0)
                Console.WriteLine("second quardrant");
            else
                Console.WriteLine("Third quardrant");
            Console.ReadLine();
        }
    }
}
