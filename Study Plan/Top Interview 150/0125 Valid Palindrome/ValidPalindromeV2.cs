/*  
    Problem
    --------------------------------------------------------------------------------
    125. Valid Palindrome
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 57 ms (Beats 85.70% of users with C#)
    - Memory 43.74 MB (Beats 49.44% of users with C#)
*/

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var phrase = s.ToLower();
        var left = 0;
        var right = phrase.Length - 1;

        while (left < right)
        {
            var first = phrase[left];
            var last = phrase[right];

            if (!char.IsLetterOrDigit(first))
            {
                left++;
            }
            else if (!char.IsLetterOrDigit(last))
            {
                right--;
            }
            else
            {
                if (first != last)
                {
                    return false;
                }

                left++;
                right--;
            }
        }

        return true;
    }
}