/*  
    Problem
    --------------------------------------------------------------------------------
    242. Valid Angram
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/valid-anagram/solutions/4529354/java-beats-97-in-runtime-time-complexity-o-n-log-n-dual-pivot-quicksort/

    - Runtime 2 ms (Beats 97.03% of users with Java)
    - Memory 44.52 MB (Beats 19.23% of users with Java)
*/

class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) return false;
        char[] source = s.toCharArray();
        char[] target = t.toCharArray();
        /* 
         *  The sorting algorithm is a Dual-Pivot Quicksort.
         *  This algorithm offers O(n log(n)) performance on all data sets,
         *  and is typically faster than traditional (one-pivot) Quicksort
         *  implementations.
         *
         *  https://github.com/openjdk/jdk/blob/master/src/java.base/share/classes/java/util/DualPivotQuicksort.java
         */
        Arrays.sort(source);
        Arrays.sort(target);
        return new String(source).equals(new String(target));
    }
}
