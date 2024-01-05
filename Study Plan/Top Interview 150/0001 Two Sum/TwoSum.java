/*  
    Problem
    --------------------------------------------------------------------------------
    1. Two Sum
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 45 ms (Beats 31.77% of users with Java)
    - Memory 44.88 MB (Beats 6.73% of users with Java)
*/

class Solution {
    public int[] twoSum(int[] nums, int target) {
        for (int i = 0; i < nums.length; i++) {
            for (int j = i + 1; j < nums.length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] {i, j};
                }
            }
        }
        return new int[0];
    }
}