/*  
    Problem
    --------------------------------------------------------------------------------
    9. Palindrome Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 52 ms (Beats 6.52% of users with C#)
    - Memory 33.04 MB (Beats 19.29% of users with C#)
*/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        var original = Convert.ToString(x);
        var reversed = new string(original.ToCharArray().Reverse().ToArray());
        
        return string.Equals(original, reversed);
    }
}