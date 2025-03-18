using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    //Write a C# program that takes an array of strings as input, concatenates all the elements into a single string,
    //extracts numeric characters from the concatenated string
    // and calculates the maximum, minimum, and difference between the extracted numeric values.
    //If no numeric characters are found, return 0 for
    //maximum, minimum, and difference.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String seprated by Space in between");
            string[] strings = Console.ReadLine().Split(' ');

            /* string concatinatedString = string.Join("", strings);
            Console.WriteLine("Concatinated String: "+concatinatedString);

            var charNumric = concatinatedString.Where(c => char.IsDigit(c)).ToArray();

            if(charNumric.Length==0)
            {
                Console.WriteLine("Maximum: 0");
                Console.WriteLine("Minimum: 0");
                Console.WriteLine("Difference: 0");
            }
            else
            {
                int[] intNumeric = charNumric.Select(c=>int.Parse(c.ToString())).ToArray();
                int maxValue = intNumeric.Max();
                int minValue = intNumeric.Min();
                int difference = maxValue - minValue;
                Console.WriteLine("Maximum Value:" + maxValue);
                Console.WriteLine("Minimum Value:" + minValue);
                Console.WriteLine("Difference Value:" + difference);
            }*/

            string concatinatedString = "";
            foreach (string s in strings)
            {
                concatinatedString += s;
            }
            Console.WriteLine(concatinatedString);


            List<int> extractedNum = new List<int>();
            foreach (char c in concatinatedString)
            {
                if (char.IsDigit(c))
                {
                    extractedNum.Add(int.Parse(c.ToString()));
                }
            }
                Console.WriteLine("Extracted Numbers: [" + string.Join(", ", extractedNum) + "]");
            
                // Step 3: Calculate the maximum, minimum, and difference
                if (extractedNum.Count == 0)
                {
                    Console.WriteLine("Maximum: 0");
                    Console.WriteLine("Minimum: 0");
                    Console.WriteLine("Difference: 0");
                }
                else
                {
                    int max = extractedNum.Max();
                    int min = extractedNum.Min();
                    int difference = max - min;

                    Console.WriteLine($"Maximum: {max}");
                    Console.WriteLine($"Minimum: {min}");
                    Console.WriteLine($"Difference: {difference}");
                }
            
        }
    }
}