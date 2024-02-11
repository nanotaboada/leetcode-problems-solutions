/*  
    Problem
    --------------------------------------------------------------------------------
    205. Isomorphic Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/isomorphic-strings/solutions/4484437/c-time-and-space-complexity-o-n-detailed-step-by-step-explanation-dictionary-and-hashset/

    - Runtime 63 ms Beats (84.64% of users with C#)
    - Memory 42.33 MB (Beats 8.05% of users with C#)
*/

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        // Constraints: t.length == s.length
        var length = s.Length;

        // Map of source (Key) and target (Value) characters
        var charMap = new Dictionary<char, char>(length);
        // Set of characters that have already been mapped
        var charSet = new HashSet<char>(length);

        for (var i = 0; i < length; i++)
        {
            // Loop through the characters of both strings
            var source = s[i];
            var target = t[i];

            // Check if the character from the source has already been mapped
            if (charMap.ContainsKey(source))
            {
                // Verify that the mapping matches
                if (charMap[source] != target)
                {
                    // Inconsistency
                    return false;
                }
            }
            // The character hasn't been mapped yet
            else
            {
                // Check if the character from the target has already been mapped
                if (charSet.Contains(target))
                {
                    // Already mapped to another character
                    return false;
                }

                // Add the source/target character mapping
                charMap[source] = target;
                // Add the target character to the set of already mapped
                charSet.Add(target);
            }
        }

        return true;
    }
}