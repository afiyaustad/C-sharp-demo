//LongestUniqueSubstring: Write logic to find the longest substring of the input string without repeating characters.
//2.AreAnagrams: Write logic to check if two input strings are anagrams of each other.
//3. CapitalizeWords: Implement logic to capitalize the first letter of each word in the input string.
//4. CountVowelsAndConsonants: Write logic to count the number of vowels and consonants in the input string.

using System;
using System.Collections.Generic;
using System.Linq;

public class AdvancedStringFunctions
{
    // Function to find the longest substring without repeating characters
    public static string LongestUniqueSubstring(string input)
    {
        int maxLength = 0;
        int start = 0;
        string longestSubstring = string.Empty;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int end = 0; end < input.Length; end++)
        {
            char currentChar = input[end];

            // If the character is already in the dictionary, move the start pointer
            if (charIndexMap.ContainsKey(currentChar))
            {
                start = Math.Max(start, charIndexMap[currentChar] + 1);
            }

            // Update the position of the current character in the dictionary
            charIndexMap[currentChar] = end;

            // Check if the current substring is the longest
            if (end - start + 1 > maxLength)
            {
                maxLength = end - start + 1;
                longestSubstring = input.Substring(start, maxLength);
            }
        }

        return longestSubstring;
    }

    // Function to check if two strings are anagrams
    public static bool AreAnagrams(string str1, string str2)
    {
        // If lengths are different, they cannot be anagrams
        if (str1.Length != str2.Length)
            return false;

        // Sort both strings and compare them
        var sortedStr1 = new string(str1.ToLower().OrderBy(c => c).ToArray());
        var sortedStr2 = new string(str2.ToLower().OrderBy(c => c).ToArray());

        return sortedStr1 == sortedStr2;
    }

    // Function to capitalize the first letter of each word in a string
    public static string CapitalizeWords(string input)
    {
        var words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", words);
    }

    // Function to count the number of vowels and consonants in a string
    public static (int vowels, int consonants) CountVowelsAndConsonants(string input)
    {
        int vowels = 0;
        int consonants = 0;
        string vowelChars = "aeiouAEIOU";

        foreach (char c in input)
        {
            if (Char.IsLetter(c))
            {
                if (vowelChars.Contains(c))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        return (vowels, consonants);
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        string testString = "programming";
        string testString2 = "margrop";

        Console.WriteLine("Longest Unique Substring: " + LongestUniqueSubstring(testString));
        Console.WriteLine("Are Anagrams: " + AreAnagrams(testString, testString2));
        Console.WriteLine("Capitalized Words: " + CapitalizeWords("hello world from csharp"));

        var counts = CountVowelsAndConsonants(testString);
        Console.WriteLine("Vowels: " + counts.vowels + ", Consonants: " + counts.consonants);
    }
}
