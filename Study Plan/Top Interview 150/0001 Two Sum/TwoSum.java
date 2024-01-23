/*  
    Problem
    --------------------------------------------------------------------------------
    1. Two Sum
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/two-sum/solutions/4614745/java-based-on-hints-beats-91-in-runtime-time-and-space-complexity-o-n/
    
    - Runtime 2 ms (Beats 91.12% of users with Java)
    - Memory 44.74 MB (Beats 39.86% of users with Java)
*/

public class Solution {
    public int[] twoSum(int[] nums, int target) {
        // Hint 3
        // The second train of thought is, without changing the array, can we
        // use additional space somehow? Like maybe a hash map to speed up the
        // search?
        HashMap<Integer, Integer> numberAndIndex = new HashMap<>(nums.length);
        for (int index = 0; index < nums.length; index++) {
            // Hint 2
            // "y which is value - x where value is the input parameter"
            // hints the concept of the complement:
            // x + y = target
            // y = target - x
            int complement = target - nums[index];
            if (numberAndIndex.containsKey(complement)) {
                return new int[] { numberAndIndex.get(complement), index };
            }
            numberAndIndex.put(nums[index], index);
        }
        // You may assume that each input would have exactly one solution   
        throw new IllegalArgumentException();
    }
}
