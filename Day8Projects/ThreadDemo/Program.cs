using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    internal class Program
    {
        public static void Fun1()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Func1() writes {0}", i);

            }

        }

        public static void Fun2()
        {
            for (int j = 20; j > 0; j--)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Func2() writes {0}", j);


            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("start of main()");
            ThreadStart t1 = new ThreadStart(Fun1);
            Thread first = new Thread(t1);
            ThreadStart t2 = new ThreadStart(Fun2);
            Thread second = new Thread(t2);
            second.Priority = ThreadPriority.Highest;
            //  first.Priority = ThreadPriority.Lowest;
            first.Start();
            second.Start();
            Console.WriteLine("End of main()");
            Console.ReadLine();
        }
    }
    }

