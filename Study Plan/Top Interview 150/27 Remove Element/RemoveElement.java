/*  
    Problem
    --------------------------------------------------------------------------------
    27. Remove Element
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/remove-element/solutions/4453892/java-in-place-time-complexity-o-n-space-complexity-o-1-runtime-0-ms-beats-100/
    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.58 MB (Beats 11.45% of users with Java)
*/

class Solution {
    public int removeElement(int[] nums, int val) {
        if (nums.length == 0) return 0;
        // Consider the number of elements in nums which are not equal to val
        // be k
        var k = 0;
        for (var index = 0; index < nums.length; index++) {
            if (nums[index] != val) {
                // Swap the non-val element to the front (in-place)
                nums[k] = nums[index];
                // Increment the number of non-val elements
                k++;
            }
        }
        return k;
    }
}