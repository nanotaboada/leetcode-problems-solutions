/*  
    Problem
    --------------------------------------------------------------------------------
    383. Ransom Note
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 73 ms (Beats 59.17% of users with C#)
    - Memory 45.46 MB (Beats 20.18% of users with C#)
*/
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteLetters = ransomNote.ToList();
        var magazineLetters = magazine.ToList();
        var lettersUsed = 0;

        foreach (var letter in ransomNoteLetters)
        {
            if (magazineLetters.Contains(letter))
            {
                magazineLetters.Remove(letter);
                lettersUsed++;
            }
        }

        return ransomNote.Length == lettersUsed;
    }
}