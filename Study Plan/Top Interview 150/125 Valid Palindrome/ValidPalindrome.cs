/*  
    Problem
    --------------------------------------------------------------------------------
    125. Valid Palindrome
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/valid-palindrome/solutions/4384299/clean-solution-in-c-beats-80-01-in-runtime/

    - Runtime 66 ms (Beats 80.57% of users with C#)
    - Memory 42.44 MB (Beats 34.19% of users with C#)
*/
public class Solution
{
    public bool IsPalindrome(string phrase)
    {
        var characters = phrase
            .ToLower()
            .Where(character => char.IsLetterOrDigit(character)
                && !char.IsPunctuation(character)
                && !char.IsWhiteSpace(character))
            .ToArray();

        var forward = new string(characters);
        var backward = new string(forward.ToCharArray().Reverse().ToArray());

        return forward == backward;
    }
}