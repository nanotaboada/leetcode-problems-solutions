/*  
    Problem
    --------------------------------------------------------------------------------
    392. Is Subsequence
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 92.10% of users with Java)
    - Memory 41.29 MB (Beats 26.67% of users with Java)
*/

class Solution {
    public boolean isSubsequence(String s, String t) {
        String subsequence = s;
        int subsequenceLength = subsequence.length();
        int subsequencePointer = 0;
        String sequence = t;
        int sequenceLength = sequence.length();
        int sequencePointer = 0;
        while (subsequencePointer < subsequenceLength && sequencePointer < sequenceLength) {
            if (subsequence.charAt(subsequencePointer) == sequence.charAt(sequencePointer)) {
                subsequencePointer++;
                sequencePointer++;
            } else {
                sequencePointer++;
            }
        }
        return subsequencePointer == subsequenceLength;
    }
}
