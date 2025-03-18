using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadandWriteOnlyProperty
{ /*
    //write only proeprty(only set shoudl be there from version 2 wihtout validaton)
    class Customer
    {
        private int customerid;
        private string customername;

        public int CUSTID
        {
            set
            {
                customerid = value;
            }

        }

        public string CUSTNAME
        {
            set
            {
                customername = value;
            }
        }

        public void displaycustomer()
        {
            Console.WriteLine($"{customerid}--{customername}");
        }
    }
        internal class Program
    {
       
        static void Main(string[] args)
        {
            Customer cc = new Customer();
            cc.CUSTID = 1001;
            cc.CUSTNAME = "sudha";
            cc.displaycustomer();

            Console.ReadLine();
        }
    }*/



    /*
    //readonly proeprties(onely get is there set is not there)
    class Customer
    {
        private int customerid;
        private string customername;
        public void setcustomerdata(int customerid1, string customername1)
        {
            customerid = customerid1;
            customername = customername1;
        }
        public int CUSTID
        {
            get
            {
                return customerid;
            }

        }

        public string CUSTNAME
        {
            get
            {
                return customername;
            }
        }


    }
    class Program
    {

        static void Main(string[] args)
        {

            Customer cc = new Customer();
            cc.setcustomerdata(1001, "ravi");
            Console.WriteLine($"{cc.CUSTID}--{cc.CUSTNAME}");
            Console.ReadLine();

        }
    } */


    //Automimplemented proeprties
    class Customer
    {
        public int customerid { get; set; }
        public string customername { get; set; }


    }
    class Program
    {
        
        static void Main(string[] args)
        {

            Customer cc = new Customer();
            cc.customerid = 1001;
            cc.customername = "mahesh";
            Console.WriteLine($"{cc.customerid}--{cc.customername}");
            Console.ReadLine();

        }
    }
}
