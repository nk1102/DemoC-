using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    // code for the Leetcode problem 


    public static  int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int start = 0;
        Dictionary<char, int> charMap = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++)
        {
            if (charMap.ContainsKey(s[end]))
            {
                // If the current character is already in the map, update the start pointer
                // to the next index after the last occurrence of the character.
                start = Math.Max(start, charMap[s[end]] + 1);
            }

            charMap[s[end]] = end; // Update the index of the current character
            maxLength = Math.Max(maxLength, end - start + 1); // Update the maximum length
        }

        return maxLength;
    }

    public static void Main()
    {
        String str = Console.ReadLine();
        Console.WriteLine(LengthOfLongestSubstring(str));
    }
}