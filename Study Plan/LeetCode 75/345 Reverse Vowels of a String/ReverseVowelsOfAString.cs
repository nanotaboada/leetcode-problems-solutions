/*  
    Problem
    --------------------------------------------------------------------------------
    345. Reverse Vowels of a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/reverse-vowels-of-a-string/solutions/4384067/c-linq-time-complexity-o-n-m-space-complexity-o-n-beats-81-in-runtime/

    - Time Complexity O(n + m)
    - Space Complexity O(n)

    - Runtime 74 ms (Beats 81.94% of users with C#)
    - Memory 37.96 MB (Beats 52.28% of users with C#)
*/

public class Solution
{
    public string ReverseVowels(string s)
    {
        var text = new StringBuilder();
        var next = 0;

        var vowels = s
            .Where(letter => isVowel(letter))
            .Reverse()
            .ToArray();

        foreach (var letter in s)
        {
            if (isVowel(letter))
            {
                text.Append(vowels[next]);
                next++;
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