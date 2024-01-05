/*  
    Problem
    --------------------------------------------------------------------------------
    242. Valid Angram
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 105 ms (Beats 14.88% of users with C#)
    - Memory 42.95 MB (Beats 10.54% of users with C#)
*/


public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var source = new string(s.OrderBy(character => character).ToArray());
        var target = new string(t.OrderBy(character => character).ToArray());

        return source == target;
    }
}