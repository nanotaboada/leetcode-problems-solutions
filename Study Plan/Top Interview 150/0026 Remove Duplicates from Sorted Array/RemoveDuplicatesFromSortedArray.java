/*  
    Problem
    --------------------------------------------------------------------------------
    26. Remove Duplicates from Sorted Array
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 83.65% of users with Java)
    - Memory 44.90 MB (Beats 25.39% of users with Java)
*/

public class Solution {
    public int removeDuplicates(int[] nums) {
        if (nums.length == 1) return 1;
        // Consider the number of unique elements of nums to be k
        var k = 0;
        for (var index = 0; index < nums.length - 1; index++) {
            if (nums[index] != nums[index + 1]) {
                nums[k++] = nums[index];
            }
        }
        nums[k++] = nums[nums.length - 1];
        return k;
    }
}