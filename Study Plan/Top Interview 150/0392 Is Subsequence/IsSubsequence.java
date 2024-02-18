/*  
    Problem
    --------------------------------------------------------------------------------
    392. Is Subsequence
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 91.07% of users with Java)
    - Memory 41.24 MB (Beats 74.55% of users with Java)
*/

class Solution {
    public boolean isSubsequence(String s, String t) {
        if (s.length() == 0) return true;
        String subSequence = s;
        int subSequenceLength = subSequence.length();
        int subSequencePointer = 0;
        String sequence = t;
        int sequenceLength = sequence.length();
        int sequencePointer = 0;
        while (subSequencePointer < subSequenceLength
            && sequencePointer < sequenceLength) {
            if (subSequence.charAt(subSequencePointer) == sequence.charAt(sequencePointer)) {
                subSequencePointer++;
                sequencePointer++;
            } else {
                sequencePointer++;
            }
        }
        return subSequencePointer == subSequenceLength;
    }
}
