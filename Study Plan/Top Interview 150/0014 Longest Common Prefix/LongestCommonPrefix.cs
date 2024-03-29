/*
    Problem
    --------------------------------------------------------------------------------
    14. Longest Common Prefix
*/

/*
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/longest-common-prefix/solutions/4432653/c-beats-85-in-runtime-time-complexity-o-n-log-n-space-complexity-o-n/

    - Runtime 65 ms (Beats 85.12% of users with C#)
    - Memory 42.54 MB (Beats 24.10% of users with C#)
*/

public class Solution
{
    /* 
        Vertical method

        -->                 ---->               ----> x
        |f| l o w e r       |f l| o w e r       |f l o| w e r
        |f| l o w           |f l| o w           |f l o| w
        |f| l i g h t       |f l| i g h t        f l i g h t
    */
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs[0].Length == 0) return string.Empty;
        
        var prefix = new StringBuilder();

        // Sort by the largest word to prevent System.IndexOutOfRangeException
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

        // Loop through all characters of the first word
        for (var i = 0; i < strs[0].Length; i++)
        {
            var character = strs[0][i];

            // Loop through all words
            for (var j = 0; j < strs.Length; j++)
            {
                // Check our current character on all words 
                if (strs[j][i] != character)
                {
                    return prefix.ToString();
                }
            }
            // Collect the common character among all words
            prefix.Append(character);
        }
        
        return prefix.ToString();
    }
}