//1.InsertAtEveryNthPosition: Write logic to insert a specified character at every nth position in the input string.
//2. RemoveAllOccurrences: Write logic to remove all occurrences of a specific character from the input string.
//3. ReplaceNthOccurrence: Implement logic to replace the nth occurrence of a substring in the input string with another substring.
//4. RemoveAfterIndex: Write logic to remove all characters from the string after a specified index

using System;

public class StringModification
{
    // Function to insert a character at every nth position in a string
    public static string InsertAtEveryNthPosition(string input, char toInsert, int n)
    {
        if (n <= 0) return input; // If n is less than or equal to zero, return the input string unchanged.

        string result = string.Empty;

        // Iterate through the input string and insert the character at every nth position
        for (int i = 0; i < input.Length; i++)
        {
            result += input[i];

            // Check if we need to insert the character (every nth position)
            if ((i + 1) % n == 0)
            {
                result += toInsert;
            }
        }

        return result;
    }

    // Function to remove all occurrences of a specific character from a string
    public static string RemoveAllOccurrences(string input, char toRemove)
    {
        return input.Replace(toRemove.ToString(), string.Empty);
    }

    // Function to replace the nth occurrence of a substring with another substring
    public static string ReplaceNthOccurrence(string input, string toReplace, string replacement, int n)
    {
        int occurrenceCount = 0;
        int index = 0;

        // Loop through the string to find the nth occurrence of the substring
        while ((index = input.IndexOf(toReplace, index)) != -1)
        {
            occurrenceCount++;
            if (occurrenceCount == n)
            {
                input = input.Substring(0, index) + replacement + input.Substring(index + toReplace.Length);
                break;
            }
            index += toReplace.Length;
        }

        return input;
    }

    // Function to remove all characters after a specific index
    public static string RemoveAfterIndex(string input, int index)
    {
        if (index < 0 || index >= input.Length) return input; // If the index is invalid, return the input string unchanged.

        return input.Substring(0, index + 1); // Return the substring from the start to the specified index (inclusive).
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        string testString = "hello-world-hello-world";

        // Test the InsertAtEveryNthPosition method
        Console.WriteLine("Insert at Every 3rd Position: " + InsertAtEveryNthPosition(testString, '*', 3));

        // Test the RemoveAllOccurrences method
        Console.WriteLine("Remove All Occurrences of '-': " + RemoveAllOccurrences(testString, '-'));

        // Test the ReplaceNthOccurrence method
        Console.WriteLine("Replace 2nd Occurrence of 'world': " + ReplaceNthOccurrence(testString, "world", "C#", 2));

        // Test the RemoveAfterIndex method
        Console.WriteLine("Remove After Index 10: " + RemoveAfterIndex(testString, 10));
    }
}
