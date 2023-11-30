/*  
    Problem
    --------------------------------------------------------------------------------
    392. Is Subsequence
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    - Runtime 70 ms (Beats 28.69% of users with C#)
    - Memory 37.93 MB (Beats 31.18% of users with C#)
*/
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        string subsequence = s;
        int subsequencePointer = 0;
        string sequence = t;
        int sequencePointer = 0;

        while (subsequencePointer < subsequence.Length && sequencePointer < sequence.Length)
        {
            if (subsequence[subsequencePointer] == sequence[sequencePointer])
            {
                subsequencePointer++;
                sequencePointer++;
            }
            else
            {
                sequencePointer++;
            }
        }

        return subsequencePointer == subsequence.Length;
    }
}