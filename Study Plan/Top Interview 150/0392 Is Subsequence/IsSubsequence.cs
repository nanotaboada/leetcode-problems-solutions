/*  
    Problem
    --------------------------------------------------------------------------------
    392. Is Subsequence
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    - Runtime 58 ms (Beats 84.33% of users with C#)
    - Memory 39.62 MB (Beats 9.69% of users with C#)
*/

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var subsequence = s;
        var subsequenceLength = subsequence.Length;
        var subsequencePointer = 0;
        var sequence = t;
        var sequenceLength = sequence.Length;
        var sequencePointer = 0;

        while (subsequencePointer < subsequenceLength && sequencePointer < sequenceLength)
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

        return subsequencePointer == subsequenceLength;
    }
}