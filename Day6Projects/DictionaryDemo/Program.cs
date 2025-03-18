using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Customer
    {

        public int CustomerID { set; get; }
        public string CustomerName { set; get; }

        internal class Program
        {
            static void Main(string[] args)
            {
                Dictionary<int, string> dicobj = new Dictionary<int, string>();
                Console.WriteLine("\n enter number of  elements in dictionary dicobj ..");
                int counter = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine("enter key :");
                    int key = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter value :");
                    string value = Console.ReadLine();
                    dicobj.Add(key, value);
                }
                Console.WriteLine("\n Prining the dictionary ..");
                foreach (KeyValuePair<int, string> pair in dicobj)
                {
                    Console.WriteLine("{0}--{1}", pair.Key, pair.Value);
                }
                Dictionary<double, Customer> dicofcustomers =
                    new Dictionary<double, Customer>()
                    {
            {101.1,new Customer(){CustomerID=101,CustomerName="kumar"} },
             {101.2,new Customer(){CustomerID=102,CustomerName="sita"} }
                    };
                Console.WriteLine("\nprinting cusotmer dictionary:");
                foreach (var cusotmer in dicofcustomers)
                {
                    Console.WriteLine("{0}:-->{1},{2}",
                        cusotmer.Key,
                    cusotmer.Value.CustomerID, cusotmer.Value.CustomerName);

                }
                Console.ReadLine();
            
        }
        }
    }
}
