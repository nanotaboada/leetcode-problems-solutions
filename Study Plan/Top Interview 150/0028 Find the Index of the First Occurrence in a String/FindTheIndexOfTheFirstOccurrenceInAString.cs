/*  
    Problem
    --------------------------------------------------------------------------------
    28. Find the Index of the First Occurrence in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/solutions/4384285/c-beats-96-in-runtime-time-complexity-o-n-space-complexity-o-1/

    - Runtime 37 ms (Beats 96.74% of users with C#)
    - Memory 37.71 MB (Beats 38.11% of users with C#)
*/
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Contains(needle, StringComparison.Ordinal))
        {
            return haystack.IndexOf(needle, StringComparison.Ordinal);
        }
        else
        {
            return -1;
        }
    }
}