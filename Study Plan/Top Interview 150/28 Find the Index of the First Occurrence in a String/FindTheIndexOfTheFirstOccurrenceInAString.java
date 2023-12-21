/*  
    Problem
    --------------------------------------------------------------------------------
    28. Find the Index of the First Occurrence in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/solutions/4432832/clean-simple-solution-in-java-beats-100-in-runtime/

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.36 MB (Beats 5.11% of users with Java)
*/

class Solution {
    public int strStr(String haystack, String needle) {
        if (haystack.contains(needle)) {
            return haystack.indexOf(needle);
        } else {
            return -1;
        }
    }
}
