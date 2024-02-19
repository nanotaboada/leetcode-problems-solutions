/*  
    Problem
    --------------------------------------------------------------------------------
    345. Reverse Vowels of a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------  
    - Runtime 54 ms (Beats 95.01% of users with C#)
    - Memory 43.10 MB (Beats 93.41% of users with C#)
*/

public class Solution
{
    public String ReverseVowels(string s)
    {
        var text = s.ToCharArray();
        var left = 0;
        var right = s.Length - 1;

        // Loop inwards (left --> <-- right)
        while (left < right)
        {
            // Find left vowel
            while (left < right
                && !isVowel(text[left]))
            {
                left++;
            }
            // Find right vowel
            while (left < right
                && !isVowel(text[right]))
            {
                right--;
            }
            // Swap left and right vowels
            if (left < right)
            {
                var vowel = text[left];
                text[left] = text[right];
                text[right] = vowel;
                left++;
                right--;
            }
        }

        return new string(text);
    }

    public bool isVowel(char letter)
    {
        return "aeiouAEIOU".Contains(letter);
    }
}