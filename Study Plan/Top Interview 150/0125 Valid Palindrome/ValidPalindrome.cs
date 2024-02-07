/*  
    Problem
    --------------------------------------------------------------------------------
    125. Valid Palindrome
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/valid-palindrome/solutions/4384299/c-linq-time-and-space-complexity-o-m-beats-79-in-runtime/

    - Runtime 66 ms (Beats 79.50% of users with C#)
    - Memory 42.44 MB (Beats 33.89% of users with C#)
*/

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var characters = s
            .ToLower()
            .Where(character => char.IsLetterOrDigit(character))
            .ToArray();

        var forward = new string(characters);
        var backward = new string(forward.ToCharArray().Reverse().ToArray());

        return forward == backward;
    }
}