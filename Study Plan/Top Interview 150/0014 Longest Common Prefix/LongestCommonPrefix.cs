/*  
    Problem
    --------------------------------------------------------------------------------
    14. Longest Common Prefix
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 90 ms (Beats 64.71% of users with C#)
    - Memory 39.88 MB (Beats 73.07% of users with C#)
*/
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        /* 
            Vertical method

            -->                 ---->               ----> x
            |f| l o w e r       |f l| o w e r       |f l o| w e r
            |f| l o w           |f l| o w           |f l o| w
            |f| l i g h t       |f l| i g h t        f l i g h t
        */

        // sort by the largest word to prevent: System.IndexOutOfRangeException
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

        var prefix = new StringBuilder();

        if (strs.Length == 0)
        {
            return prefix.ToString();
        }
        else
        {
            // loop through all characters of the first word
            for (var i = 0; i < strs[0].Length; i++)
            {
                var character = strs[0][i];

                // loop through all words
                for (var j = 0; j < strs.Length; j++)
                {
                    // check our current character on all words 
                    if (strs[j][i] != character)
                    {
                        return prefix.ToString();
                    }
                }
                // collect the common character among all words
                prefix.Append(character);
            }
            
            return prefix.ToString();
        }
    }
}