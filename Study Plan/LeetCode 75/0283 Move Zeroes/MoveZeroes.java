/*
    Problem
    --------------------------------------------------------------------------------
    283. Move Zeroes
*/

/*  
    Solution
    --------------------------------------------------------------------------------

    Overwrite the collection moving the non-zero elements to the beginning
    -----------------------------------------------------------
    | index |  nums (Before)   |   nums (After)    | position |
    -----------------------------------------------------------
    |       |  v               |  v                |          |
    |   0   | [0, 1, 0, 3, 12] | [0, 1, 0, 3, 12]  |    0     |
    |       |     v            |  *  v             |          |
    |   1   | [0, 1, 0, 3, 12] | [1, 1, 0, 3, 12]  |    1     |
    |       |        v         |  *     v          |          |
    |   2   | [0, 1, 0, 3, 12] | [1, 1, 0, 3, 12]  |    1     |
    |       |           v      |  *  *     v       |          |
    |   3   | [0, 1, 0, 3, 12] | [1, 3, 0, 3, 12]  |    2     |
    |       |              v   |  *  *  *      v   |          |
    |   4   | [0, 1, 0, 3, 12] | [1, 3, 12, 3, 12] |    3     |
    -----------------------------------------------------------
    
    Fill the remaining positions with zeros (from last position until length)
    ----------------------------------------------------
    | position |   nums (Before)   |   nums (After)    |
    ----------------------------------------------------
    |          |            v      |            *      |
    |    3     | [1, 3, 12, 3, 12] | [1, 3, 12, 0, 12] |
    |          |               v   |            *  *   |
    |    4     | [1, 3, 12, 3, 12] | [1, 3, 12, 0, 0]  |
    ----------------------------------------------------

    https://leetcode.com/problems/move-zeroes/solutions/4431061/java-in-place-beats-85-in-runtime-time-complexity-o-n-space-complexity-o-1/

    - Runtime 2 ms (Beats 85.32% of users with Java)
    - Memory 45.75 MB (Beats 87.05% of users with Java)
*/

class Solution {
    public void moveZeroes(int[] nums) {
        int position = 0;
        // Overwrite the collection moving the non-zero elements to the beginning
        for (int index = 0; index < nums.length; index++) {
            if (nums[index] != 0) {
                nums[position] = nums[index];
                position++;
            }
        }
        // Fill the remaining positions with zeros (from last position until length)
        while(position < nums.length) {
            nums[position] = 0;
            position++;
        }
    }
}
