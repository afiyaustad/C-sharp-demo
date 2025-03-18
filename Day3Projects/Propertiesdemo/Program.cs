using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Propertiesdemo
{
    /* //version 1
    class Customer
    {
        private int customerid;
        private string customername;

        public void setcustomer(int id1)
        {
            customerid = id1;
        }
        public int getcustomerid()
        {
            return customerid;
        }

        public void setcustomername(string name1)
        {
            customername = name1;
        }
        public string getcustomername()
        {
            return customername;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cc = new Customer();

            cc.setcustomer(1001);
            cc.setcustomername("kiran");
            Console.WriteLine($"{cc.getcustomerid()}--{cc.getcustomername()}");
            Console.ReadLine();
        }
    } */

    //versions 2 and validating it
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
            get
            {
                return customerid;
            }
        }
        /*
        public string CUSTNAME
        {
            set
            {
                customername = value;
            }
            get
            {
                return customername;
            } */

        public string CUSTNAME
        {
            set
            {
                // Validate that the name does not contain numbers
                if (Regex.IsMatch(value, @"^[a-zA-Z\s]+$")) // Allows letters and spaces only
                {
                    customername = value;
                }
                else
                {
                    throw new ArgumentException("Customer name should only contain letters and spaces.");
                }
            }
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
                cc.CUSTID = 1001;
                cc.CUSTNAME = "sudha";
                Console.WriteLine($"{cc.CUSTID}--{cc.CUSTNAME}");

                Console.ReadLine();

            }
        }
    }
}
