/*  
    Problem
    --------------------------------------------------------------------------------
    58. Length of Last Word
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/solutions/4384285/c-time-complexity-o-m-n-space-complexity-o-1-beats-71-in-runtime/
    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.23 MB (Beats 75.76% of users with Java)
*/

class Solution {
    public int lengthOfLastWord(String s) {
        String[] words = s.split(" ");
        String last = words[words.length - 1].trim();
        return last.length();
    }
}
