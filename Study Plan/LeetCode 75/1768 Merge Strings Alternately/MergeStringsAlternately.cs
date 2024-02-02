/*  
    Problem
    --------------------------------------------------------------------------------
    1768. Merge Strings Alternately
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 52 ms (Beats 77.01% of users with C#)
    - Memory 39.87 MB (Beats 19.97% of users with C#)
*/

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var merged = new StringBuilder(word1.Length + word2.Length);

        var longer = (word1.Length >= word2.Length) ? word1 : word2;
        var shorter = (word1.Length < word2.Length) ? word1 : word2;

        // Merge the strings by adding letters in alternating order,
        // starting with word1.
        var alternated = word1
            .Zip(word2, (char1, char2) => string.Concat(char1, char2))
            .Select(pair => pair)
            .ToList();

        alternated.ForEach(pair => merged.Append(pair));

        // If a string is longer than the other, append the additional letters
        // onto the end of the merged string.
        var additional = new string(longer
            .Skip(shorter.Length)
            .ToArray());

        merged.Append(additional);
        
        return merged.ToString();
    }
}