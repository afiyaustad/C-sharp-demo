using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //while (x <= 100)
            //{
            //    Console.Write($"{x}  ");
            //    x++;
            //}

            /*do
            {
                Console.Write($"{x}   ");

                x++;
            }
            while (x <= 100);

            */

            /* //Repeatedly ask
            int counter = 1;
            do
            {
                Console.Write($"{counter}  ");
                if (counter % 100 == 0 && counter != 0)
                {
                    Console.WriteLine("\n do you want to continue <y/n>?");
                    if (Console.ReadLine() != "y")
                    {
                        //keepgoing = false;
                        break;
                    }

                }
                counter++;
            } while (true);  */


            /*
            //modified switch
            int a, b, c;// choice;
            char choice2;
            Console.WriteLine("Enter values in a and b ..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\n enter your choice ....");
                Console.WriteLine("***************************");
                Console.WriteLine("A.Addition...");
                Console.WriteLine("B.Substraction ...");
                Console.WriteLine("C.Multiplication ...");
                Console.WriteLine("D.Division ...");
                Console.WriteLine("E.All Actions ");
                //choice = Convert.ToInt32(Console.ReadLine());
                choice2 = Convert.ToChar(Console.ReadLine());

                switch (choice2)
                {

                    case 'A':
                    case 'a':
                        c = a + b;
                        Console.WriteLine($"The sum is {c} ");
                        break;
                    case 'B':
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine($"The substraction is {c}");
                        break;

                    case 'C':
                        c = a * b;
                        Console.WriteLine($"The Multiplication  is {c} ");
                        break;
                    case 'D':
                        c = a / b;
                        Console.WriteLine($"The division is {c}");
                        break;

                    case 'E':
                        c = a + b;
                        Console.WriteLine($"The sum is {c} ");
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine($"The substraction is {c}");
                        c = a * b;
                        Console.WriteLine($"The Multiplication  is {c} ");
                        c = a / b;
                        Console.WriteLine($"The division is {c}");


                        break;

                    default:
                        Console.WriteLine("Enter values between A to B  only...");
                        break;
                }
                Console.WriteLine("\ndo you want to continue<y/n>?");
                if (Console.ReadLine() != "y")
                {
                    break;
                }

            } while (true);  */



            // denaomination demo   480 total amount and

            //Denaomination();

            // factoraial finding...
            int i; float f = 1.0F;
            Console.WriteLine("Enter the number to find factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine($"The factorial of {n} is {f}");
        

        Console.ReadLine();
        }

        //private static void Denaomination()
        //{
        //    int sum = 0;
        //    int x = 1;
        //    int y = 5;
        //    int z = 10;
        //    int noofnotes = 0;
        //    while (sum < 480)
        //    {
        //        sum = x + y + z;
        //        noofnotes++;
        //        x = x + 1;
        //        y = y + 5;
        //        z = z + 10;
        //    }
        //    Console.WriteLine($"No of notes {noofnotes} and total nontes {3 * noofnotes}");
        //}



    }
}
