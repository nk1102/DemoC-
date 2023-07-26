using DemoC_;
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
     /*   String str = Console.ReadLine();
        Console.WriteLine(LengthOfLongestSubstring(str));*/



        // OOP code 

        OOP account = new OOP("123456789", "John Doe", 1000.00m);

        // Performing some operations on the account
        account.CheckBalance();  // Initial balance

        account.Deposit(500.00m);
        account.Withdraw(200.00m);
        account.Withdraw(1500.00m); // This should fail due to insufficient funds

        account.CheckBalance();  // Final balance

        Console.ReadKey();
    }
}