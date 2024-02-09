/*
    Problem
    --------------------------------------------------------------------------------
    12. Integer to Roman
*/

/*
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/integer-to-roman/solutions/4508995/c-beats-97-in-runtime-faster-than-dictionary-time-and-space-complexity-o-1/
    - Runtime 45 ms (Beats 97.96% of users with C#)
    - Memory 45.47 MB (Beats 43.58% of users with C#)
*/

public class Solution
{
    public string IntToRoman(int num)
    {
        var roman = new StringBuilder();
    
        var numbers = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        var symbols = new string[] {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        for (var index = 0; index < numbers.Length; index++)
        {
            while (num >= numbers[index])
            {
                roman.Append(symbols[index]);
                num -= numbers[index];
            }
        }

        return roman.ToString();
    }
}
