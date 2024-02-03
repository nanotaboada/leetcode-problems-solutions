/*  
    Problem
    --------------------------------------------------------------------------------
    151. Reverse Words in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 53 ms (Beats 98.84% of users with C#)
    - Memory 40.24 MB (Beats 34.07% of users with C#)
*/

public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Reverse();
    
        return string.Join(" ", words);  
    }
}