using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Customer
    {

        public int CustomerID { set; get; }
        public string CustomerName { set; get; }

        public static List<Customer> retrive()
        {
            List<Customer> list = new List<Customer>()
            {
              new Customer{CustomerID=101,CustomerName="sita"},
              new Customer{CustomerID=102,CustomerName="suresh"},
              new Customer{CustomerID=103,CustomerName="mahesh"}

            };
            return list;
        }
        public static void PrintCustomer(List<Customer> clist)
        {
            Console.WriteLine("\ndisplaying cusomters");
            foreach (Customer cust in clist)
            {
                Console.WriteLine($"{cust.CustomerID}--{cust.CustomerName}");
            }
        }
        public static void insertcustomer(Customer customer, List<Customer> clist)
        {
            clist.Add(customer);
        }
        public static Customer findcustomer(int custid1, List<Customer> clist)
        {
            Customer customerfound = null;
            foreach (Customer c in clist)
            {
                if (c.CustomerID == custid1)
                {
                    customerfound = c;
                    break;
                }

            }
            return customerfound;

        }
        public static void updatecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    Console.WriteLine("enter new name");
                    string newname = Console.ReadLine();
                    clist[i].CustomerName = newname;
                }
            }
        }

        public static void deletecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    clist.RemoveAt(i);
                }
            }
        }
        internal class Program
        {


            static void Main(string[] args)
            {
                List<int> numbers = new List<int>() { 12, 45, 67, 89, 99, 192 };
                List<int> numbers2 = new List<int>();
                numbers2.Add(12);
                numbers2.AddRange(new int[] { 12, 45, 67, 89, 100 });
                Console.WriteLine("\n displaying numbers ");
                foreach (int number in numbers)
                {

                    Console.Write($"{number}  ");

                }
                Console.WriteLine("\n displaying numbers2");
                foreach (int num in numbers2)
                {

                    Console.Write($"{num}  ");
                }

                List<string> boysnames = new List<string>() { "kiran", "karthik", "mahesh", "suresh" };
                var girlnames = new List<string>();
                girlnames.Add("sudha");
                girlnames.AddRange(new string[] { "sita", "shanthi", "priya", "suman" });

                Console.WriteLine("\n\n displaying boys ");
                foreach (string boy in boysnames)
                {

                    Console.WriteLine($"{boy}");

                }
                Console.WriteLine("\n displaying girls");
                foreach (string girl in girlnames)
                {

                    Console.WriteLine($"{girl}");
                }

                int[] aa = new int[] { 12, 33, 44, 5, 89, 56, 71, 90, 12, 44 };
                //remove  duplicate elements from the array and give it to me 

                List<int> result = new List<int>();

                foreach (int number in aa)
                {
                    bool found = false;
                    foreach (int resultitem in result)
                    {
                        if (resultitem == number)
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        result.Add(number);
                    }
                }
                Console.WriteLine("\n after removing duplicate elements ..");
                foreach (int k in result)
                {
                    Console.Write($"{k}  ");
                }
                List<Customer> custlist = Customer.retrive();
                Customer.PrintCustomer(custlist);
                Console.WriteLine("\n enter the customer to be added in the list");
                Customer c4 = new Customer()
                {
                    CustomerID = 104,
                    CustomerName = "rajesh"
                };
                Customer.insertcustomer(c4, custlist);
                Customer.PrintCustomer(custlist);
                Console.WriteLine("\n enter the customer id to find");
                int custid2 = Convert.ToInt32(Console.ReadLine());
                Customer customergot = Customer.findcustomer(custid2, custlist);
                if (customergot != null)
                {
                    Console.WriteLine($"The cusotmer wit id {customergot.CustomerID} is having name {customergot.CustomerName}");
                }
                else
                {
                    Console.WriteLine("\n the customer is not found ");
                }
                Console.WriteLine("\n enter the id of customer whos name u want to change ");
                int customerid2 = Convert.ToInt32(Console.ReadLine());
                Customer.updatecustomer(customerid2, custlist);
                Customer.PrintCustomer(custlist);
                Console.WriteLine("\n enter the id of customer whos name u want to delete ");
                int customerid3 = Convert.ToInt32(Console.ReadLine());
                Customer.deletecustomer(customerid2, custlist);
                Customer.PrintCustomer(custlist);
                Console.ReadLine();
            }
        }

    }
}