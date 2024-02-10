/*  
    Problem
    --------------------------------------------------------------------------------
    28. Find the Index of the First Occurrence in a String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/solutions/4432832/java-time-complexity-o-m-n-space-complexity-o-1-runtime-0-ms-beats-100/

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.36 MB (Beats 54.51% of users with Java)
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
