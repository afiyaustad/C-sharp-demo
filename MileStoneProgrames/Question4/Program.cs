using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.FindUniqueElements: Write logic to extract all unique elements from an array.
//2. FindIntersection: Write logic to find the common elements between two arrays.
//3. MergeAndRemoveDuplicates: Write logic to merge two arrays into one, removing duplicate elements.
//4. LongestIncreasingSubsequence: Write logic to find the longest sequence of increasing elements in the array

namespace Question4
{
    public class AdvancedArrayOperations
    {
        // Function to find all unique elements in an array
        public static int[] FindUniqueElements(int[] arr)
        {
            // Implement logic here
            return arr.Distinct().ToArray();
        }
        // Function to find the intersection of two arrays
        public static int[] FindIntersection(int[] arr1, int[] arr2)
        {
            // Implement logic here
            return arr1.Intersect(arr2).ToArray();
        }
        // Function to merge two arrays and remove duplicates
        public static int[] MergeAndRemoveDuplicates(int[] arr1, int[] arr2)
        {
            // Implement logic here
            return arr1.Concat(arr2).Distinct().ToArray();
        }
        // Function to find the longest increasing subsequence in an array
        public static int[] LongestIncreasingSubsequence(int[] arr)
        {
            // Implement logic here
            if (arr.Length == 0)
                return new int[0];

            List<int> subsequence = new List<int>();
            List<int> tempSubsequence = new List<int>();

            foreach (int num in arr)
            {
                if (tempSubsequence.Count == 0 || num > tempSubsequence[tempSubsequence.Count - 1])
                {
                    tempSubsequence.Add(num);
                }
                else
                {
                    if (tempSubsequence.Count > subsequence.Count)
                    {
                        subsequence = new List<int>(tempSubsequence);
                    }
                    tempSubsequence.Clear();
                    tempSubsequence.Add(num);
                }
            }
            if (tempSubsequence.Count > subsequence.Count)
            {
                subsequence = new List<int>(tempSubsequence);
            }

            return subsequence.ToArray();
        
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 2, 3, 4, 5 };
            int[] array2 = { 2, 3, 6, 7, 5 };
            Console.WriteLine("Unique Elements: " + string.Join(", ", FindUniqueElements(array1)));
            Console.WriteLine("Intersection: " + string.Join(", ", FindIntersection(array1, array2)));
            Console.WriteLine("Merged Without Duplicates: " + string.Join(", ", MergeAndRemoveDuplicates(array1, array2)));
            Console.WriteLine("Longest Increasing Subsequence: " + string.Join(", ", LongestIncreasingSubsequence(array1)));
        }
    }
}
