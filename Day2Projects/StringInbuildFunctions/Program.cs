using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInbuildFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "world";

            //properties and fields

            string sample = "";
            string sample2 = string.Empty;
            //here chars means index proeprty 

            Console.WriteLine($"chars means indexing if " +
                $"i use like this then chars only it means [] :{str[1]}");

            Console.WriteLine($"Length: {str.Length}");

            // Modifying
            Console.WriteLine("\nModifying:");
            Console.WriteLine($"Insert: {str.Insert(11, "Beautiful")}");
            Console.WriteLine($"Remove: {str.Remove(7, 2)}");
            Console.WriteLine($"Replace: {str.Replace("World", "C#")}");
            Console.WriteLine($"Trim: '{str.Trim()}'");
            Console.WriteLine($"TrimStart: '{str.TrimStart()}'");
            Console.WriteLine($"TrimEnd: '{str.TrimEnd()}'");
            Console.WriteLine($"PadLeft: '{str2.PadLeft(10, '*')}'");
            Console.WriteLine($"PadRight: '{str2.PadRight(10, '-')}'");
            Console.WriteLine($"ToUpper: {str3.ToUpper()}");
            Console.WriteLine($"ToLower: {str2.ToLower()}");

            // extracting 
            Console.WriteLine("\n Extracting ...");
            Console.WriteLine($"Subsstring :{str.Substring(6, 5)}");
            Console.WriteLine($"split :{string.Join(",", str.Split(' '))}");

            Console.WriteLine($"{string.Join(" ", "ravi", "kumar")}");

            // Formatting
            Console.WriteLine("\nFormatting:");
            double number = 12345.6789;
            Console.WriteLine($"Currency: {number.ToString("C")}");
            // Formatting
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("\nFormatting:");
            //double number = 12345.6789;
            Console.WriteLine($"US Currency: {number.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"Indian Currency: {number.ToString("C", new CultureInfo("en-IN"))}");
            Console.WriteLine($"Euro Currency: {number.ToString("C", new CultureInfo("fr-FR"))}");


            Console.WriteLine($"Exponential: {number.ToString("E")}");
            Console.WriteLine($"General: {number.ToString("G")}");
            Console.WriteLine($"Percentage: {number.ToString("P")}");
            DateTime date = DateTime.Now;
            Console.WriteLine($"Short Date: {date.ToString("d")}");
            Console.WriteLine($"Long Date: {date.ToString("D")}");
            Console.WriteLine($"Short Time: {date.ToString("t")}");
            Console.WriteLine($"Long Time: {date.ToString("T")}");

            // Searching
            Console.WriteLine("\nSearching:");
            Console.WriteLine($"StartsWith 'Hello': {str.StartsWith(" Hello")}");
            Console.WriteLine($"EndsWith '!': {str.EndsWith("!")}");
            Console.WriteLine($"IndexOf 'World': {str.IndexOf("World")}");
            Console.WriteLine($"Contains 'World': {str.Contains("World")}");

           

            // comparing 

            Console.WriteLine("\n Comparing");
            string ss1 = "daghu";
            string ss2 = "raghu";

            String kk = "raghu";
            Console.WriteLine($"compare :{string.Compare(ss1, ss2)}");   //<0 means ss1 is smaller than ss2 
            Console.WriteLine($"compare :{string.Compare(ss2, ss1)}");// > 0 means ss2 is largrr comes after ss1 
            Console.WriteLine($"compare :{ss1.CompareTo(kk)}");   //<0 means ss1 is smaller than ss2 
            Console.WriteLine($"Equals :{ss2.Equals(ss1)}");
            Console.WriteLine($"Equals :{ss2.Equals(kk)}");

            Console.ReadLine();
        }
    }
}
