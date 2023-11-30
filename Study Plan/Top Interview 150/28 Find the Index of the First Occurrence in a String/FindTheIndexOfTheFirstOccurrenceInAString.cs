/*  
    Problem
    --------------------------------------------------------------------------------
    28. Find the Index of the First Occurrence in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 56 ms (Beats 72.53% of users with C#)
    - Memory 37.56 MB (Beats 9.41% of users with C#)
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