/*  
    Problem
    --------------------------------------------------------------------------------
    28. Find the Index of the First Occurrence in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/solutions/4384285/c-time-complexity-o-m-n-space-complexity-o-1-beats-71-in-runtime/

    - Time Complexity O(m * n)
    - Space Complexity O(1)

    - Runtime 56 ms (Beats 71.05% of users with C#)
    - Memory 37.56 MB (Beats 9.55% of users with C#)
*/
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Contains(needle))
        {
            return haystack.IndexOf(needle);
        }
        else
        {
            return -1;
        }
    }
}