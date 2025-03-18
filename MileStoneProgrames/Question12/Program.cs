//. ReverseString: Use StringBuilder to reverse the input string.
//2. RemoveVowels: Implement logic to remove all vowels (a, e, i, o, u) from the input string using StringBuilder .
//3.AppendToWords: Use StringBuilder to append a specified character at the start and end of each word in a sentence.
//4. ReplaceWord: Implement logic to replace all occurrences of a specific word in the input string with another word using StringBuilder 

using System;
using System.Linq;
using System.Text;

public class StringBuilderOperations
{
    // Function to reverse a string using StringBuilder
    public static string ReverseString(string input) { 
    //{
    //    StringBuilder reversed = new StringBuilder(input);
    //    reversed.Reverse(); // StringBuilder has a built-in Reverse method
    //    return reversed.ToString();
    StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--) // Traverse the string in reverse order
        {
            reversed.Append(input[i]); // Append each character to StringBuilder
        }
return reversed.ToString();
    }

    // Function to remove all vowels from a string using StringBuilder
    public static string RemoveVowels(string input)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            if (!"aeiouAEIOU".Contains(c)) // Check if character is not a vowel
            {
                result.Append(c); // Append non-vowel characters to the StringBuilder
            }
        }
        return result.ToString();
    }

    // Function to append a specified character at the start and end of each word in a sentence
    public static string AppendToWords(string input, char toAppend)
    {
        StringBuilder result = new StringBuilder();
        string[] words = input.Split(' '); // Split the sentence into words

        foreach (string word in words)
        {
            result.Append(toAppend).Append(word).Append(toAppend).Append(" ");
        }

        return result.ToString().Trim(); // Trim the extra space at the end
    }

    // Function to replace all occurrences of a specific word in a string with another word using StringBuilder
    public static string ReplaceWord(string input, string targetWord, string replacementWord)
    {
        StringBuilder result = new StringBuilder(input);
        result.Replace(targetWord, replacementWord); // Replace all occurrences of targetWord
        return result.ToString();
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        string testString = "StringBuilder is powerful";

        Console.WriteLine("Reversed String: " + ReverseString(testString));
        Console.WriteLine("String Without Vowels: " + RemoveVowels(testString));
        Console.WriteLine("Appended to Words: " + AppendToWords(testString, '*'));
        Console.WriteLine("Replace 'powerful' with 'amazing': " + ReplaceWord(testString, "powerful", "amazing"));
    }
}
