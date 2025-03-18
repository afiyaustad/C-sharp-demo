using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructordemo
{
    class Customer
    {
        public int customerid;
        public string custname;

        public Customer()//default constructor 
        {
            Console.WriteLine("Default constructor ..");
            this.customerid = 1001;
            this.custname = "Suresh";
            Console.WriteLine($"{customerid}--{custname}");
        }
        static Customer()
        {
            Console.WriteLine("static constructor ..");
        }
        public Customer(int cid, string custname1)
        {
            Console.WriteLine("paramatierzed constructor ..");

            this.customerid = cid;
            this.custname = custname1;
            Console.WriteLine($"{customerid}--{custname}");

        }

        public Customer(Customer c)
        {
            Console.WriteLine("copy constructor ..");

            this.customerid = c.customerid;
            this.custname = c.custname;
            Console.WriteLine($"{customerid}--{custname}");
        }


    }
    class Program
    {
        public static void ShowMessage(int age = 22, string name = "Mr.X")//optional paramerts
        {
            Console.WriteLine($"The person with name {name} is having age {age}");
        }
        static void Main(string[] args)
        {
            Customer defaultcustomer = new Customer();//default
            Customer defaultcustomer2 = new Customer();//default
            Customer paraconst = new Customer(1002, "Ravi");//paramatized
            Customer cc2 = new Customer(1003, "sudha");
            Customer cc5 = new Customer(cc2);
            Customer cc4 = new Customer(defaultcustomer);//copy constructor
            ShowMessage(23, "santosh");
            // as per my order i want to send valeus which is named paramter 
            ShowMessage(name: "ramesh", age: 34);//named paramters 
            ShowMessage(); //optional
            ShowMessage(18);// one is given another will be default 

            Console.ReadLine();

        }
    }
}
