/*  
    Problem
    --------------------------------------------------------------------------------
    205. Isomorphic Strings
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 51 ms (Beats 97.73% of users with C#)
    - Memory 42.10 MB (Beats 32.78% of users with C#)
*/

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var sources = new int[128];
        var targets = new int[128];

        for (var index = 0; index < s.Length; index++)
        {
            var source = s[index];
            var target = t[index];

            if (sources[source] != targets[target])
            {
                return false;
            }

            sources[source] = index + 1;
            targets[target] = index + 1;   
        }

        return true;
    }
}
