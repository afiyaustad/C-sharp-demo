
//1.InsertAfterCharacter: Write logic to insert a substring after every occurrence of a specified character in the input string.
//2. RemoveFirstNCharacters: Write logic to remove the first n characters from the input string.
//3. ReplaceVowels: Implement logic to replace all vowels in the input string with a specified character.
//4. ReverseWords: Write logic to reverse only the words in a sentence, maintaining the order of spaces.

using System;
using System.Linq;
using System.Text;

public class AdvancedStringModification
{
    // Function to insert a substring at every position where a specific character is found
    public static string InsertAfterCharacter(string input, char target, string toInsert)
    {
        StringBuilder result = new StringBuilder();

        // Iterate through the input string and insert the specified substring after the target character
        foreach (char c in input)
        {
            result.Append(c);
            if (c == target)
            {
                result.Append(toInsert);
            }
        }

        return result.ToString();
    }

    // Function to remove the first n characters from a string
    public static string RemoveFirstNCharacters(string input, int n)
    {
        if (n >= input.Length)
        {
            return string.Empty; // If n is greater than or equal to the length of the string, return an empty string
        }

        return input.Substring(n); // Remove the first n characters
    }

    // Function to replace all vowels in a string with a specified character
    public static string ReplaceVowels(string input, char replacement)
    {
        StringBuilder result = new StringBuilder();
        string vowels = "aeiouAEIOU"; // Vowels to look for in the string

        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                result.Append(replacement); // Replace vowels with the specified character
            }
            else
            {
                result.Append(c); // Keep non-vowel characters as they are
            }
        }

        return result.ToString();
    }

    // Function to reverse only the words in a sentence while preserving spaces
    public static string ReverseWords(string input)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder word = new StringBuilder();

        foreach (char c in input)
        {
            if (c != ' ') // If it's a non-space character, accumulate it as part of the word
            {
                word.Append(c);
            }
            else
            {
                if (word.Length > 0)
                {
                    result.Append(ReverseString(word.ToString())); // Reverse the current word
                    word.Clear(); // Clear the word for the next word
                }
                result.Append(c); // Add the space
            }
        }

        // Append the last word if the string doesn't end with a space
        if (word.Length > 0)
        {
            result.Append(ReverseString(word.ToString()));
        }

        return result.ToString();
    }

    // Helper function to reverse a string
    private static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        string testString = "hello world this is C#";

        // Test InsertAfterCharacter
        Console.WriteLine("Insert After Character 'o': " + InsertAfterCharacter(testString, 'o', "-inserted"));

        // Test RemoveFirstNCharacters
        Console.WriteLine("Remove First 5 Characters: " + RemoveFirstNCharacters(testString, 5));

        // Test ReplaceVowels
        Console.WriteLine("Replace Vowels with '*': " + ReplaceVowels(testString, '*'));

        // Test ReverseWords
        Console.WriteLine("Reverse Words: " + ReverseWords(testString));
    }
}
