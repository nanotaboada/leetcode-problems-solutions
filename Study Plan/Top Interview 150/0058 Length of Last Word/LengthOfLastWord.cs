/*  
    Problem
    --------------------------------------------------------------------------------
    58. Length of Last Word
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 42 ms (Beats 84.14% of users with C#)
    - Memory 38.35 MB (Beats 16.20% of users with C#)
*/

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var last = words[^1];
        
        return last.Length;
    }
}