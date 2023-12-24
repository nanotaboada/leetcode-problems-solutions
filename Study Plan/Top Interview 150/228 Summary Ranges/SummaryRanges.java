/*  
    Problem
    --------------------------------------------------------------------------------
    228. Summary Ranges
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/summary-ranges/solutions/4453926/java-time-and-space-complexity-o-n-beats-90-in-runtime/
    - Runtime 2 ms (Beats 90.76% of users with Java)
    - Memory 41.40 MB (Beats 9.42% of users with Java)
*/

class Solution {
    public List<String> summaryRanges(int[] nums) {
        ArrayList<String> ranges = new ArrayList<>();
        if (nums.length == 0) {
            return ranges;
        }
        int index = 0;
        // Cycle the entire collection
        while (index < nums.length) {
            int a = nums[index];
            int b = a;
            // Loop while a + 1 = b to define the range
            // (and index is within bounds)
            while (index < nums.length - 1
                && nums[index] + 1 == nums[index + 1]) {
                b = nums[index + 1];
                index++;
            }
            // There is more than one element in the range
            if (a != b) {
                ranges.add(String.format("%s->%s", a, b));
            // Just a single element
            } else {
                ranges.add(String.format("%s", a));
            }
            index++;
        }
        return ranges;
    }
}