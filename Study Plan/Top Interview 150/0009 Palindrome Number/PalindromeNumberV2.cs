/*  
    Problem
    --------------------------------------------------------------------------------
    9. Palindrome Number
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 43 ms (Beats 80.27% of users with C#)
    - Memory 31.75 MB (Beats 79.16% of users with C#)
*/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        var original = x;
        var reversed = 0;

        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        
        return original == reversed;
    }
}
