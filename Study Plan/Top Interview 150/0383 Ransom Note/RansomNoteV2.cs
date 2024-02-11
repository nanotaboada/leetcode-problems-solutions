/*  
    Problem
    --------------------------------------------------------------------------------
    383. Ransom Note
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 57 ms (Beats 87.65% of users with C#)
    - Memory 44.90 MB (Beats 32.05% of users with C#)
*/

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        // Early return if ransomNote is longer than magazine
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        
        var lettersFromMagazine = new Dictionary<char, int>();

        // Count the occurrences of each letter in the magazine
        foreach (var letter in magazine)
        {
            if (!lettersFromMagazine.ContainsKey(letter))
            {
                lettersFromMagazine[letter] = 1;
            }
            else
            {
                lettersFromMagazine[letter]++;
            }
        }

        // Check if the ransom note can be constructed using the letters from
        // the magazine
        foreach (var letter in ransomNote)
        {
            if (!lettersFromMagazine.ContainsKey(letter)
                || lettersFromMagazine[letter] == 0)
            {
                return false;
            }

            lettersFromMagazine[letter]--;
        }

        return true;
    }
}
