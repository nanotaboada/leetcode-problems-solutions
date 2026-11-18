/*
    Problem
    --------------------------------------------------------------------------------
    1207. Unique Number of Occurrences
*/

/*
    Solution (2026 revision, written with AI assistance)
    --------------------------------------------------------------------------------
    - Time complexity O(n), space complexity O(n)
    - Map.merge replaces the getOrDefault + put pair with a single call.
    - Set.add returns false for a repeated count, so the check stops at the
      first one.
*/

class Solution {
    public boolean uniqueOccurrences(int[] arr) {
        var countByElement = new HashMap<Integer, Integer>();
        for (var element : arr) {
            countByElement.merge(element, 1, Integer::sum);
        }

        var seenCounts = new HashSet<Integer>();
        for (var count : countByElement.values()) {
            if (!seenCounts.add(count)) {
                return false;
            }
        }
        return true;
    }
}
