/*  
    Problem
    --------------------------------------------------------------------------------
    242. Valid Angram
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 3 ms (Beats 83.53% of users with Java)
    - Memory 44.78 MB (Beats 5.88% of users with Java)
*/

class Solution {
    public boolean isAnagram(String s, String t) {
        char[] sourceLetters = s.toCharArray();
        char[] targetLetters = t.toCharArray();
        /* 
         *  The sorting algorithm is a Dual-Pivot Quicksort.
         *  This algorithm offers O(n log(n)) performance on all data sets,
         *  and is typically faster than traditional (one-pivot) Quicksort
         *  implementations.
         *
         *  https://github.com/openjdk/jdk/blob/master/src/java.base/share/classes/java/util/DualPivotQuicksort.java
         */
        Arrays.sort(sourceLetters);
        Arrays.sort(targetLetters);
        String source = new String(sourceLetters);
        String target = new String(targetLetters);
        return source.equals(target);
    }
}
