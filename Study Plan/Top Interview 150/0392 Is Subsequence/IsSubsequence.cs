/*  
    Problem
    --------------------------------------------------------------------------------
    392. Is Subsequence
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    - Runtime 54 ms (Beats 68.78% of users with C#)
    - Memory 39.92 MB (Beats 31.94% of users with C#)
*/

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrWhiteSpace(s)) return true;

        var subSequence = s;
        var subSequenceLength = subSequence.Length;
        var subSequencePointer = 0;

        var sequence = t;
        var sequenceLength = sequence.Length;
        var sequencePointer = 0;

        while (subSequencePointer < subSequenceLength
            && sequencePointer < sequenceLength)
        {
            if (subSequence[subSequencePointer] == sequence[sequencePointer])
            {
                subSequencePointer++;
                sequencePointer++;
            }
            else
            {
                sequencePointer++;
            }
        }

        return subSequencePointer == subSequenceLength;
    }
}