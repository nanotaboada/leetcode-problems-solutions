/*  
    Problem
    --------------------------------------------------------------------------------
    345. Reverse Vowels of a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 80 ms (Beats 15.04% of users with C#)
    - Memory 37.96 MB (Beats 42.76% of users with C#)
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