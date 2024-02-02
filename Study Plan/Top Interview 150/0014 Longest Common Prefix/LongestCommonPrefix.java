/*
    Problem
    --------------------------------------------------------------------------------
    14. Longest Common Prefix
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 80.96% of users with Java)
    - Memory 41.38 MB (Beats 53.64% of users with Java)
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
    public String longestCommonPrefix(String[] strs) {
        if (strs[0].length() == 0) return "";
        StringBuilder prefix = new StringBuilder();
        // Sort by the largest word to prevent System.IndexOutOfRangeException
        Arrays.sort(strs, (x, y) -> Integer.compare(x.length(), y.length()));
        // Loop through all characters of the first word
        for (int i = 0; i < strs[0].length(); i++) {
            char character = strs[0].charAt(i);
            // Loop through all words
            for (var j = 0; j < strs.length; j++) {
                // Check our current character on all words 
                if (strs[j].charAt(i) != character) {
                    return prefix.toString();
                }
            }
            // Collect the common character among all words
            prefix.append(character);
        }
        return prefix.toString();
    }
}