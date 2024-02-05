/*  
    Problem
    --------------------------------------------------------------------------------
    26. Remove Duplicates from Sorted Array
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/remove-duplicates-from-sorted-array/solutions/4679210/java-in-place-beats-100-in-runtime-time-complexity-o-n-space-complexity-o-1/
    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 45.00 MB (Beats 8.56% of users with Java)
*/

public class Solution {
    public int removeDuplicates(int[] nums) {
        if (nums.length == 1) return 1;
        // Consider the number of unique elements of nums to be k
        var k = 0;
        for (var index = 0; index < nums.length - 1; index++) {
            // Compare the current element with the next element
            if (nums[index] != nums[index + 1]) {
                // If they are not equal, update the array in-place and
                // increment the count of unique elements
                nums[k] = nums[index];
                k++;
            }
        }
        // Update the last element of the array and increment the count
        nums[k] = nums[nums.length - 1];
        k++;
        return k;
    }
}