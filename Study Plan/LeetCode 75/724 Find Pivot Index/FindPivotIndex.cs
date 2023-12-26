/*
    Problem
    --------------------------------------------------------------------------------
    724. Find Pivot Index
*/

/*  
    Solution
    --------------------------------------------------------------------------------

    -----------------------------------------------
    | sumRight = 28        | sumLeft = 0          |
    -----------------------------------------------
    | -------------------> | <                    |
    | [ 1, 7, 3, 6, 5, 6 ] | [ 1, 7, 3, 6, 5, 6 ] |
    -----------------------------------------------

    -----------------------------------------------------------------------
    | i |        nums          | sumRight | sumRight == sumLeft | sumLeft |
    -----------------------------------------------------------------------
    | 0 | < i  --------------> | (28 - 1) |      (27 == 0)      | (0 + 1) |
    |   | [ 1, 7, 3, 6, 5, 6 ] |    27    |        False        |    1    |
    -----------------------------------------------------------------------
    | 1 | <--  i  -----------> | (27 - 7) |      (20 == 1)      | (1 + 7) |
    |   | [ 1, 7, 3, 6, 5, 6 ] |    20    |        False        |    8    |
    -----------------------------------------------------------------------
    | 2 | <-----  i  --------> | (20 - 3) |      (17 == 8)      | (8 + 3) |
    |   | [ 1, 7, 3, 6, 5, 6 ] |    17    |        False        |    11   |
    -----------------------------------------------------------------------
    | 3 | <--------  i  -----> | (17 - 6) |      (11 == 11)     |         |
    |   | [ 1, 7, 3, 6, 5, 6 ] |    11    |         True        |         |
    -----------------------------------------------------------------------

    https://leetcode.com/problems/find-pivot-index/solutions/4414019/clean-solution-in-c-beats-74-in-runtime-with-step-by-step-example-in-code-comments/

    - Runtime 94 ms (Beats 73.70% of users with C#)
    - Memory 46.00 MB (Beats 76.53% of users with C#)
*/

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var sumRight = nums.Sum();
        var sumLeft = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumLeft == sumRight)
            {
                return i;
            }

            sumLeft += nums[i];
        }

        return -1;
    }
}