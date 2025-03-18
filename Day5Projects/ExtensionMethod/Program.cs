using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static bool isPallindrome(this string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;

        }
    }

    public static class IntExtensions
    {
        public static bool isOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            string data = "liril";

            Console.WriteLine($"{number} is odd:{number.isOdd()}");
            Console.WriteLine($"{data} is pallindrome:{data.isPallindrome()}");
            Console.ReadLine();
        }
    }
}

