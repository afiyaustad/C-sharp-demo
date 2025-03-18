//1.RotateRight: Write logic to rotate the array to the right by a given number of steps.
//2. FindTripletsWithSum: Implement logic to find all unique triplets in the array that sum up to the given target value.
//3. MaxProductOfThree: Write logic to calculate the maximum product of any three numbers in the array.
//4. FindUniqueElement: Write logic to find the element that appears only once in an array where all other elements appear twice.

using System;
using System.Collections.Generic;

public class ArrayOperationsAdvanced
{
    // Function to rotate an array to the right by a given number of steps
    public static int[] RotateRight(int[] arr, int steps)
    {
        int n = arr.Length;
        steps = steps % n;  // To handle cases where steps is larger than the array length
        int[] result = new int[n];

        // Copy the last 'steps' elements to the beginning of the array
        for (int i = 0; i < steps; i++)
        {
            result[i] = arr[n - steps + i];
        }

        // Copy the remaining elements to their new positions
        for (int i = 0; i < n - steps; i++)
        {
            result[steps + i] = arr[i];
        }

        return result;
    }

    // Function to find all triplets in an array that sum to a specific value
    public static void FindTripletsWithSum(int[] arr, int targetSum)
    {
        Array.Sort(arr);  // Sorting helps in efficiently finding triplets
        int n = arr.Length;
        bool found = false;

        for (int i = 0; i < n - 2; i++)
        {
            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int currentSum = arr[i] + arr[left] + arr[right];

                if (currentSum == targetSum)
                {
                    Console.WriteLine($"Triplet: ({arr[i]}, {arr[left]}, {arr[right]})");
                    found = true;
                    left++;
                    right--;
                }
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No triplets found.");
        }
    }

    // Function to find the maximum product of three numbers in an array
    public static int MaxProductOfThree(int[] arr)
    {
        Array.Sort(arr);
        int n = arr.Length;

        // The maximum product could be the product of the three largest numbers
        // or the product of the two smallest numbers (if negative) and the largest positive number
        return Math.Max(arr[n - 1] * arr[n - 2] * arr[n - 3], arr[0] * arr[1] * arr[n - 1]);
    }

    // Function to find the element that appears only once in an array where every other element appears twice
    public static int FindUniqueElement(int[] arr)
    {
        int uniqueElement = 0;
        foreach (int num in arr)
        {
            uniqueElement ^= num;  // XOR all elements, duplicates cancel out
        }
        return uniqueElement;
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        int[] testArray = { 1, 2, 3, 4, 5, 6, 7 };
        int targetSum = 12;

        // Testing RotateRight method
        Console.WriteLine("Rotated Array (Right by 2): " + string.Join(", ", RotateRight(testArray, 2)));

        // Testing FindTripletsWithSum method
        Console.WriteLine("Triplets with Sum " + targetSum + ":");
        FindTripletsWithSum(testArray, targetSum);

        // Testing MaxProductOfThree method
        Console.WriteLine("Max Product of Three: " + MaxProductOfThree(testArray));

        // Testing FindUniqueElement method
        int[] uniqueArray = { 2, 2, 3, 4, 4 };
        Console.WriteLine("Unique Element: " + FindUniqueElement(uniqueArray));
    }
}
