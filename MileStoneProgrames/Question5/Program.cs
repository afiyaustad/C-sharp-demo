using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.FindMajorityElement: Write logic to identify the majority element, if one exists, in the array.
//2. FindSmallestMissingPositive: Write logic to find the smallest positive integer that is missing from the array.
//3. FindKthLargest: Implement a function to find the kth largest element in the array.
//4. ContainsDuplicate: Write logic to determine if the array contains any duplicate elements.

namespace Question5
{
    public class ArrayAdvancedChallenges
    {
        // Function to find the majority element in an array (element appearing more than n/2 times)
        public static int? FindMajorityElement(int[] arr)
        {
            // Implement logic here
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }

            int majorityThreshold = arr.Length / 2;
            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value > majorityThreshold)
                    return kvp.Key;
            }

            return null;
        }
        // Function to find the smallest missing positive integer
        public static int FindSmallestMissingPositive(int[] arr)
        {
            // Implement logic here
            int n = arr.Length;

            // Step 1: Ignore negative numbers and numbers greater than n
            HashSet<int> positiveNumbers = new HashSet<int>();
            foreach (var num in arr)
            {
                if (num > 0 && num <= n)
                    positiveNumbers.Add(num);
            }

            // Step 2: Find the smallest missing positive integer
            for (int i = 1; i <= n; i++)
            {
                if (!positiveNumbers.Contains(i))
                    return i;
            }

            // If all numbers from 1 to n are present, the missing number is n+1
            return n + 1;
        }
        // Function to find the kth largest element in the array
        public static int FindKthLargest(int[] arr, int k)
        {
            // Implement logic here
            if (k <= 0 || k > arr.Length)
                throw new ArgumentException("k is out of bounds");

            // Sort the array in descending order and return the kth largest element
            Array.Sort(arr);
            Array.Reverse(arr);

            return arr[k - 1];
        }
        // Function to check if the array contains a duplicate
        public static bool ContainsDuplicate(int[] arr)
        {
            // Implement logic here
            HashSet<int> seenElements = new HashSet<int>();

            foreach (var num in arr)
            {
                if (seenElements.Contains(num))
                    return true;  // Found a duplicate
                seenElements.Add(num);
            }

            return false;
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            int[] testArray = { 3, 1, 2, 3, 4, 2, 1 };
            Console.WriteLine("Majority Element: " + FindMajorityElement(testArray));
            Console.WriteLine("Smallest Missing Positive: " + FindSmallestMissingPositive(testArray));
            Console.WriteLine("3rd Largest Element: " + FindKthLargest(testArray, 3));
            Console.WriteLine("Contains Duplicate: " + ContainsDuplicate(testArray));
        }

    }
}
