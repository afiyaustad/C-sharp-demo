using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            int i, j;
            for(i = 1; i <= 5; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write($"{i}  ");
                }
                Console.WriteLine();    
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\n Priniting 3 by 3 matrix ");
            int[,] a = new int[3, 3];// 2 d array length,breadthh 
            //Console.WriteLine("\n Priniting 3 by 3 matrix ");
            int[,,] aa = new int[3, 3, 3];// 3 d rray length,breadth,height also comes

            Console.WriteLine("enter elements in 2d array..");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"enter [{i + 1},{j + 1}] element:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nPrinting an arrya");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}  ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\n sum of elelemts in matrix");
            int sum=0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    sum =sum+ a[i, j];
                }

            }
            Console.WriteLine($"\nn the sum is {sum}");
            Console.ReadLine();
            Console.ReadLine(); 
        }
    }
}
