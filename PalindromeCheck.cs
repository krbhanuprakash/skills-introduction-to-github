using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string input = Console.ReadLine()?.Trim();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"'{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (char.ToLowerInvariant(str[left]) != char.ToLowerInvariant(str[right]))
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
