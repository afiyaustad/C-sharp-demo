using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Program
    {

        /*
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("\n prininting the array ..");
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }*/

        public class Customer
        {
            public int CustomerId;
            public string CustomerName;
        }
        static void Main(string[] args)
        {

            /*
            // inifinite array here i am declaring also and intilizing also 
            int[] aa1 = new int[] { 12, 34, 55, 66, 71, 23 };
            int[] aa2 = new int[3] { 12, 34, 89 };//normal array where declaration and inilization 
            int[] aa3 = new int[4];// this is just declaring array is empty here 
            string[] names = new string[3] { "ravi", "mahesh", "sudha" };
            char[] chars = new char[3] { 'a', 'b', 'c', };

            int[] a = new int[5];//declared not initialized
            int i, j, sum = 0;
            Console.WriteLine("Enter values in arrray..");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter element {i + 1}:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Console.WriteLine("\n prininting the array ..");

            //for (i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"{a[i]}  ");
            //}

            PrintArray(a);
            PrintArray(aa1);

            
            for(i = 0; i < a.Length;i++)
            {
                sum=sum+a[i];
            }
            Console.WriteLine($"Sum of elements is {sum}");

            //foreach
            Console.WriteLine("\nprinting the array using for each loop");
            foreach (int ele in a)
            {
                Console.Write($"{ele}  ");
            }
            Console.WriteLine("\n modiifying array using for loop..");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * 3;
            }
            PrintArray(a);

            //searching element in array
            Console.WriteLine("\nEnter element to be searched");
            int ele1 = Convert.ToInt32(Console.ReadLine());
            int flag = 0;//using false are boolean
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == ele1)
                {
                    flag = 1;//using true are boolean
                    Console.WriteLine($"Element {ele1} found at {i + 1} index");
                    break;
                }
            }
            if(flag==0)
            { 
                    Console.WriteLine("Element not found");
                
            }

            //Sorting in array smallest at 1st position 
            Console.WriteLine("\n Sorting an array..using bubble sort.");

            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nAfer sorting printing array ....");
            PrintArray(a);
            Console.WriteLine("\n uisng in built function of Array to do the task like revese,sort");
            Array.Reverse(a);
            PrintArray(a);
            */
            Customer[] cusList = new Customer[3];
            for(int i = 0;i<cusList.Length; i++)
            {
                Customer c=new Customer();
                Console.WriteLine($"Enter customer details for {i + 1}");
                Console.WriteLine("Enter customer id: ");
                c.CustomerId=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter customer naame: ");
                c.CustomerName=Console.ReadLine();  
                cusList[i] = c; 
            }
            foreach (Customer customer in cusList)
            {
                Console.WriteLine($"Customer details are:{customer.CustomerId}-----{customer.CustomerName}");
            }
            Console.ReadLine();
        



        }
    }
}
