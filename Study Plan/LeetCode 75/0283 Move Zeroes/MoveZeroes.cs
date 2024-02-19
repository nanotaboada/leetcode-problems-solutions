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

https://leetcode.com/problems/move-zeroes/solutions/4391658/c-in-place-beats-90-in-runtime-time-complexity-o-n-space-complexity-o-1/

    - Runtime 134 ms (Beats 90.93% of users with C#)
    - Memory 57.64 MB (Beats 17.87% of users with C#)
*/

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var position = 0;

        // Overwrite the collection moving the non-zero elements to the beginning
        for (var index = 0; index < nums.Length; index++)
        {
            if (nums[index] != 0)
            {
                nums[position] = nums[index];
                position++;
            }
        }

        // Fill the remaining positions with zeros (from last position until length)
        while(position < nums.Length)
        {
            nums[position] = 0;
            position++;
        }
    }
}