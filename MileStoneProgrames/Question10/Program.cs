//1.InsertBetweenCharacters: Write logic to insert a given sequence of characters between each character of the input string.
//2. RemoveDuplicates: Write logic to remove all duplicate characters from the input string while preserving the first occurrence.
//3. ReplaceLastOccurrence: Implement logic to replace only the last occurrence of a specified substring in the input string.
//4. KeepUniqueWords: Write logic to keep only the unique words in a sentence, removing all repeated words.
using System;
using System.Collections.Generic;

public class ComplexStringModification
{
    // Function to insert a sequence of characters in between each character of the string
    public static string InsertBetweenCharacters(string input, string toInsert)
    {
        if (string.IsNullOrEmpty(input)) return input;  // Return the original string if it's empty

        var result = new System.Text.StringBuilder();
        foreach (var character in input)
        {
            result.Append(character);
            result.Append(toInsert);
        }

        // Remove the last inserted sequence
        result.Remove(result.Length - toInsert.Length, toInsert.Length);
        return result.ToString();
    }

    // Function to remove all duplicate characters from a string
    public static string RemoveDuplicates(string input)
    {
        var seen = new HashSet<char>();
        var result = new System.Text.StringBuilder();

        foreach (var character in input)
        {
            if (!seen.Contains(character))
            {
                seen.Add(character);
                result.Append(character);
            }
        }

        return result.ToString();
    }

    // Function to replace the last occurrence of a substring with another substring
    public static string ReplaceLastOccurrence(string input, string toReplace, string replacement)
    {
        int lastIndex = input.LastIndexOf(toReplace);
        if (lastIndex == -1) return input;  // If the substring doesn't exist, return original string

        return input.Substring(0, lastIndex) + replacement + input.Substring(lastIndex + toReplace.Length);
    }

    // Function to modify a string by keeping only unique words
    public static string KeepUniqueWords(string input)
    {
        var words = input.Split(' ');
        var seenWords = new HashSet<string>();
        var result = new List<string>();

        foreach (var word in words)
        {
            if (!seenWords.Contains(word))
            {
                seenWords.Add(word);
                result.Add(word);
            }
        }

        return string.Join(" ", result);
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        string testString = "hello world hello universe";

        // Insert Between Characters Test
        Console.WriteLine("Insert Between Characters: " + InsertBetweenCharacters(testString, "-"));

        // Remove Duplicates Test
        Console.WriteLine("Remove Duplicates: " + RemoveDuplicates(testString));

        // Replace Last Occurrence Test
        Console.WriteLine("Replace Last Occurrence of 'hello': " + ReplaceLastOccurrence(testString, "hello", "hi"));

        // Keep Unique Words Test
        Console.WriteLine("Keep Unique Words: " + KeepUniqueWords(testString));
    }
}
