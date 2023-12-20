/*
    Problem
    --------------------------------------------------------------------------------
    283. Move Zeroes
*/

/*  
    Solution
    --------------------------------------------------------------------------------

    Overwrite the collection moving the non-zero elements to the beginning
    -------------------------------------------------------
    | i |  nums (Before)   |   nums (After)    | position |
    -------------------------------------------------------
    |   |  v               |  v                |          |
    | 0 | [0, 1, 0, 3, 12] | [0, 1, 0, 3, 12]  |    0     |
    |   |     v            |  *  v             |          |
    | 1 | [0, 1, 0, 3, 12] | [1, 1, 0, 3, 12]  |    1     |
    |   |        v         |  *     v          |          |
    | 2 | [0, 1, 0, 3, 12] | [1, 1, 0, 3, 12]  |    1     |
    |   |           v      |  *  *     v       |          |
    | 3 | [0, 1, 0, 3, 12] | [1, 3, 0, 3, 12]  |    2     |
    |   |              v   |  *  *  *      v   |          |
    | 4 | [0, 1, 0, 3, 12] | [1, 3, 12, 3, 12] |    3     |
    -------------------------------------------------------
    
    Fill the remaining positions with zeros (from last position until length)
    ----------------------------------------------------
    | position |   nums (Before)   |   nums (After)    |
    ----------------------------------------------------
    |          |            v      |            *      |
    |    3     | [1, 3, 12, 3, 12] | [1, 3, 12, 0, 12] |
    |          |               v   |            *  *   |
    |    4     | [1, 3, 12, 3, 12] | [1, 3, 12, 0, 0]  |
    ----------------------------------------------------

    https://leetcode.com/problems/move-zeroes/solutions/4431061/in-place-solution-in-java-with-graphical-explanation-beats-67-in-runtime/

    - Runtime 2 ms (Beats 67.76% of users with Java)
    - Memory 46.78 MB (Beats 5.44% of users with Java)
*/

class Solution {
    public void moveZeroes(int[] nums) {
        int position = 0;
        // Overwrite the collection moving the non-zero elements to the beginning
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] != 0) {
                nums[position] = nums[i];
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