/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/unique-number-of-occurrences/solutions/4555311/java-based-on-hints-beats-98-in-runtime-time-and-space-complexity-o-n/
    
    - Runtime 2 ms (Beats 98.13% of users with Java)
    - Memory 41.56 MB (Beats 31.99% of users with Java)
*/

class Solution {
    public boolean uniqueOccurrences(int[] arr) {
        // Hint 1
        // Find the number of occurrences of each element in the array
        // using a hash map.
        HashMap<Integer, Integer> occurrences = new HashMap<>();
        for (int element : arr) {
            int count = occurrences.getOrDefault(element, 0) + 1;
            occurrences.put(element, count);
        }
        HashSet<Integer> uniques = new HashSet<>();
        // Hint 2
        // Iterate through the hash map and check if there is a repeated value.
        for (int occurrence : occurrences.values()) {
            // Returns true if this set did not already contain the specified element
            // https://docs.oracle.com/javase/8/docs/api/java/util/HashSet.html#add-E-
            if(!uniques.add(occurrence))
            {
                return false;
            }
        }
        return true;
    }
}