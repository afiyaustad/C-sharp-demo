using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.ReverseString: Write logic to reverse the input string.
//2. IsPalindrome: Write logic to check if the input string is the same forwards and backwards.
//3. CharacterFrequency: Implement logic to count and display the frequency of each character in the input string.
//4. FirstNonRepeatingCharacter: Write logic to find the first character in the string that does not repeat.

namespace Question6
{
    public class StringFunctions
    {
        // Function to reverse a string
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();  // Convert string to character array
            Array.Reverse(charArray);  // Reverse the character array
            return new string(charArray);
        }
        // Function to check if a string is a palindrome
        public static bool IsPalindrome(string input)
        {
            string reversed = ReverseString(input);  // Get the reversed string
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
        // Function to count the frequency of each character in a string
        public static void CharacterFrequency(string input)
        {
            // Implement logic here
            Dictionary<char, int> charCount = new Dictionary<char, int>();  // Dictionary to store character count

            foreach (char c in input)  // Iterate through each character in the string
            {
                if (charCount.ContainsKey(c))  // If the character is already in the dictionary, increment its count
                {
                    charCount[c]++;
                }
                else  // Otherwise, add it to the dictionary with an initial count of 1
                {
                    charCount[c] = 1;
                }
            }

            // Print the frequency of each character
            foreach (var entry in charCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        // Function to find the first non-repeating character in a string
        public static char? FirstNonRepeatingCharacter(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();  // Dictionary to store character count

            // Count the frequency of each character
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first non-repeating character
            foreach (char c in input)
            {
                if (charCount[c] == 1)  // If the count is 1, it means it's non-repeating
                {
                    return c;
                }
            }

            return null;
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            string testString = "civic";
            Console.WriteLine("Reversed String: " + ReverseString(testString));
            Console.WriteLine("Is Palindrome: " + IsPalindrome(testString));
            Console.WriteLine("Character Frequency:");
            CharacterFrequency(testString);
            Console.WriteLine("First Non-Repeating Character: " + FirstNonRepeatingCharacter(testString));
        }
    }
}