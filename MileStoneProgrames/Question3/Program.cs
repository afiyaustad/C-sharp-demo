using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.CalculateMedian: Write logic to sort the array and calculate the median.
//2. FindSecondLargest: Write logic to find the second largest element in the array.
//3. IsPalindrome: Write logic to check if the array is the same when reversed.
//4. RotateLeft: Write logic to rotate the array to the left by a specified number of steps.


namespace Question3
{
    public class ArrayOperations
    {
        // Function to calculate the median of an array
        public static double CalculateMedian(int[] arr)
        {
            Array.Sort(arr);

            int n = arr.Length;
            if (n % 2 == 0)
            {
                // If even, median is the average of the two middle elements
                return (arr[n / 2 - 1] + arr[n / 2]) / 2.0;
            }
            else
            {
                // If odd, median is the middle element
                return arr[n / 2];
            }
        }
        // Function to find the second largest element in an array
        public static int FindSecondLargest(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            // Second largest element is at index 1 after sorting in descending order
            return arr.Length >= 2 ? arr[1] : arr[0];
        }
        // Function to check if an array is a palindrome
        public static bool IsPalindrome(int[] arr)
        {
            // Implement logic here
            return arr.SequenceEqual(arr.Reverse());
        }
        // Function to rotate the array to the left by a given number of steps
        public static int[] RotateLeft(int[] arr, int steps)
        {
            // Implement logic here
            int n = arr.Length;
            steps = steps % n; // In case steps is greater than the length of the array
            return arr.Skip(steps).Concat(arr.Take(steps)).ToArray();
        }
            static void Main(string[] args)
        {
            int[] testArray = { 5, 1, 4, 2, 5 };
            Console.WriteLine("Median: " + CalculateMedian(testArray));
            Console.WriteLine("Second Largest: " + FindSecondLargest(testArray));
            Console.WriteLine("Is Palindrome: " + IsPalindrome(testArray));
            int[] rotatedArray = RotateLeft(testArray, 2);
            Console.WriteLine("Rotated Array: " + string.Join(", ", rotatedArray));
        }
    }
}
