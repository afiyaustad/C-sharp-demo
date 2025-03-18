using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {

        public void concat1(string s1)
        {
            string st = "world";
            s1 = s1 + st;

        }
        public void concat2(StringBuilder sb)
        {
            sb.Append(" EveryOne");
        }
        public void EqualsExample()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "kkk";
            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1 == s2}");
            s1 = s3;
            Console.WriteLine($"{s1 == s2}");
            Console.WriteLine($"{s1 == s3}");

        }
        static void Main(string[] args)
        {
            //Strings drowbacks   memory wasted
            //string is immutable means string i cannot change them but i can override them within themselves 
            //string is reference type and small string or capital String is same only same methods refflect 

            string x = "Raghavendra";
            string k = x.Substring(0, 6);
            Console.WriteLine($"The string value is {x} ");
            Console.WriteLine($"The string value is {k} ");
            // if u override it actual string will chnage 

            x = x.Substring(0, 6);
            Console.WriteLine($"The string value is {x} ");

            //String concat function 
            string fname;
            string mname;
            string lname;
            Console.WriteLine("enter first name");
            fname = Console.ReadLine();
            Console.WriteLine("enter middle name ");
            mname = Console.ReadLine();
            Console.WriteLine("enter last name ");
            lname = Console.ReadLine();
            string fullname = fname + " " + mname + " " + lname;
            Console.WriteLine($"{fullname}");
            string fullname2 = string.Concat(fname, " ", mname, " ", lname);
            Console.WriteLine($"{fullname2.ToUpper()}");
            Console.WriteLine("Enter new fname to be replced ");
            string newfname = Console.ReadLine();
            Console.WriteLine($"The new full name is {fullname.Replace(fname, newfname)}");



            //String Builder is mutable    one time declare and many time used
            StringBuilder sb = new StringBuilder();
            sb.Append("Mohan ");
            sb.Append("kumar");
            Console.WriteLine(sb.ToString());


            //calling func
            Program pp = new Program();
            pp.EqualsExample();

            string s1 = "hello";
            StringBuilder sb1 = new StringBuilder("hai");
            Program pp2 = new Program();
            pp2.concat1(s1);
            pp2.concat2(sb1);
            Console.WriteLine($"{s1}--{sb1}");


            string[] weekdays =
                new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // i want the output like this 
            // Monday ,Tuesday ,Wednesday ,Thursday,Friday ,Saturday and Sunday but it will not happen as it is
            // immutable 
            // it will if i overrdie the array but wihtout overrding i want to  modify means i will keept this array 
            // in string buildwer and will modify 

            StringBuilder sb3 = new StringBuilder();
            for (int i = 0; i < weekdays.Length; i++)
            {
                sb3.Append(weekdays[i]);
                if (i < weekdays.Length - 2)
                {
                    sb3.Append(',');
                }
                else if (i == weekdays.Length - 2)
                {
                    sb3.Append(" and ");
                }
            }
            Console.WriteLine(sb3.ToString());
            Console.ReadLine();
            

        }
    }
}
