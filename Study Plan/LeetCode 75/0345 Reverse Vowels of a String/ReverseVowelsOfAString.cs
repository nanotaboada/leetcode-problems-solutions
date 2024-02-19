/*  
    Problem
    --------------------------------------------------------------------------------
    345. Reverse Vowels of a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/reverse-vowels-of-a-string/solutions/4384067/c-linq-beats-91-in-runtime-time-and-space-complexity-o-n-stringbuilder-and-stack/
    
    - Runtime 58 ms (Beats 91.50% of users with C#)
    - Memory 44.92 MB (Beats 31.66% of users with C#)
*/

public class Solution
{
    public string ReverseVowels(string s)
    {
        var text = new StringBuilder(s.Length);
        var vowels = new Stack<char>();
        
        foreach (var letter in s)
        {
            if (isVowel(letter))
            {
                vowels.Push(letter);
            }
        }

        foreach (var letter in s)
        {
            if(isVowel(letter))
            {
                text.Append(vowels.Pop());
            }
            else
            {
                text.Append(letter);
            }
        }

        return text.ToString();
    }

    public bool isVowel(char letter)
    {
        return "aeiouAEIOU".Contains(letter);
    }
}
