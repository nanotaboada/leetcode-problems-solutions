/*  
    Problem
    --------------------------------------------------------------------------------
    205. Isomorphic Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 68 ms (Beats 70.06% of users with C#)
    - Memory 39.63 MB (Beats 51.66% of users with C#)
*/
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        // map of source (Key) and target (Value) characters
        var charMap = new Dictionary<char, char>();
        
        // set of characters that have already been mapped
        var charSet = new HashSet<char>();

        for (var i = 0; i < s.Length; i++)
        {
            // loop through the characters of both strings
            char source = s[i];
            char target = t[i];

            // check if the character from the source has already been mapped
            if (charMap.ContainsKey(source))
            {
                // verify that the mapping matches
                if (charMap[source] != target)
                {
                    // inconsistency
                    return false;
                }
            }
            // the character hasn't been mapped yet
            else
            {
                // check if the character from the target has already been mapped
                if (charSet.Contains(target))
                {
                    // already mapped to another character
                    return false;
                }

                // add the source/target character mapping
                charMap[source] = target;
                // add the target character to the set of alreaady mapped
                charSet.Add(target);
            }
        }

        return true;
    }
}