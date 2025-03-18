using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,choice;
            Console.WriteLine("Enter values in a and b");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Enter the choice");
            Console.WriteLine("********************************");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
                {
                case 1: c = a + b;
                    Console.WriteLine($"The Addition  is {c}");
                    break;
                case 2:
                    c = (a > b) ? (a - b) : (b - a);
                    Console.WriteLine($"The substraction is {c}");
                    break;

                case 3:
                    c = a * b;
                    Console.WriteLine($"The Multiplication  is {c} ");
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine($"The division is {c}");
                    break;

                default:
                    Console.WriteLine("Enter values between 1 to 4 only...");
                    break;
            }
            Console.ReadLine();
        
        }
    }
}
