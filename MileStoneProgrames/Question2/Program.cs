using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{

    //    Write a C# program to perform the following operations on a given string:
    //    1.Check Substring: Verify if a given substring exists in the main string.
    //2. Replace Characters: Replace all occurrences of a specified character in the string with another character.
    //3. Swap Case: Convert uppercase characters to lowercase and lowercase characters to uppercase in the string.
    //4. Remove Whitespace: Remove all whitespace characters from the string.
    //5. Count Letters: Count the frequency of each letter (ignoring case) in the string.
    internal class Program
    {
        static void Main(string[] args)
        {
            string mainString = GetInput("Enter the main string:");

            string substring = GetInput("Enter the substring to check:");

            char charToReplace = GetInput("Enter the character to replace:")[0];

            char replacementChar = GetInput("Enter the replacement character:")[0];

            bool substringExists = CheckSubstringExists(mainString, substring);

            string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);

            string caseSwapped = SwapCase(mainString);

            string noSpaces = RemoveWhitespace(mainString);

            Dictionary<char, int> letterCount = CountLetters(mainString);

            Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
            Console.WriteLine($"Replaced: {replacedString}");
            Console.WriteLine($"Case Swapped: {caseSwapped}");
            Console.WriteLine($"No Spaces: {noSpaces}");
            Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");

        }

        static bool CheckSubstringExists(string main, string sub)
        {
            // Complete this function
            if (main.Contains(sub))
            {
                return true;
            }
            return false; // Replace with actual logic
        }
        static string ReplaceCharacter(string input, char oldChar, char newChar)
        {
            // Complete this function
            
            return input.Replace(oldChar,newChar); // Replace with actual logic
        }

        static string SwapCase(string input)
        {
            // Complete this function
            char[] charArray=input.ToCharArray();
            for(int c=0;c<charArray.Length;c++)
            {
                if (char.IsLower(charArray[c]))
                {
                    charArray[c] = char.ToUpper(charArray[c]);
                }
                else if (char.IsUpper(charArray[c]))
                {
                    charArray[c]=char.ToLower(charArray[c]);
                }
            }
            return new string(charArray); // Replace with actual logic
        }
        

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static string RemoveWhitespace(string input)
        {
            // Complete this function
            return input.Replace(" ",""); // Replace with actual logic
        }

        static Dictionary<char, int> CountLetters(string input)
        {
            // Complete this function
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            foreach (char c in input.ToLower())  // Convert to lower case to ignore case
            {
                if (char.IsLetter(c))  // Consider only letters
                {
                    if (letterCounts.ContainsKey(c))
                        letterCounts[c]++;
                    else
                        letterCounts[c] = 1;
                }
            }
            return letterCounts;
        }

    }
}
