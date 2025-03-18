using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_genericArrayListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add(true);
            obj.Add(DateTime.Now);
            obj.Add("Raghavendra");
            obj.Add(123.234);

            Console.WriteLine($"No of elements :{obj.Count}");
            Console.WriteLine($"The capacity is :{obj.Capacity}");
            foreach (var ele in obj)
            {
                Console.WriteLine($"{ele}  ");
            }
            int[] fourmore = new int[] { 10, 20, 30, 40 };
            obj.AddRange(fourmore);
            Console.WriteLine($"No of elements :{obj.Count}");
            Console.WriteLine($"The capacity is :{obj.Capacity}");
            foreach (var ele in obj)
            {
                Console.WriteLine($"{ele}  ");
            }
            obj.Insert(0, "firstelelemt");
            obj.RemoveAt(3);
            int[] threemore = new int[] { 100, 200, 300, 40 };
            obj.InsertRange(4, threemore);
            Console.WriteLine($"\nNo of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type
            {
                Console.WriteLine($"{ele}  ");
                
            }
            Console.ReadLine();
        }
    }
}
