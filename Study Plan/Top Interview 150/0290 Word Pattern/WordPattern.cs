/*  
    Problem
    --------------------------------------------------------------------------------
    290. Word Pattern
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/word-pattern/solutions/4678691/c-dictionaries-beats-87-in-runtime-time-and-space-complexity-o-n/
    - Runtime 49 ms (Beats 89.66% of users with C#)
    - Memory 39.48 MB (Beats 8.22% of users with C#)
*/

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(" ");
        if (pattern.Length != words.Length) return false;

        var letterToWord = new Dictionary<char, string>(pattern.Length);
        var wordToLetter = new Dictionary<string, char>(words.Length);

        for (var index = 0; index < pattern.Length; index++)
        {
            var letter = pattern[index];
            var word = words[index];

            letterToWord.TryAdd(letter, word);
            wordToLetter.TryAdd(word, letter);

            if(letterToWord[letter] != word || wordToLetter[word] != letter)
            {
                return false;
            }
        }

        return true;
    }
}