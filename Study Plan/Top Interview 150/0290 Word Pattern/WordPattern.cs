/*  
    Problem
    --------------------------------------------------------------------------------
    290. Word Pattern
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 49 ms (Beats 89.66% of users with C#)
    - Memory 39.48 MB (Beats 8.22% of users with C#)
*/

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(" ");
        if (pattern.Length != words.Length) return false;

        // A bijection, bijective function, or one-to-one correspondence between
        // two mathematical sets is a function such that each element of the 
        // second set (the codomain) is mapped to from exactly one element of
        // the first set (the domain). 
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