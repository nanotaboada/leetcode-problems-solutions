/*  
    Problem
    --------------------------------------------------------------------------------
    58. Length of Last Word
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 65 ms (Beats 19.48% of users with C#)
    - Memory 36.39 MB (Beats 91.03% of users with C#)
*/
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var wordsAndSpaces = s.Split(" ");
        var words = wordsAndSpaces.Where(word => !string.IsNullOrWhiteSpace(word));
        var last = words.Last();
        
        return last.Length;
    }
}