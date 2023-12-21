/*  
    Problem
    --------------------------------------------------------------------------------
    70. Climbing Stairs
*/

/*  
    Solution
    --------------------------------------------------------------------------------

    - Ways to reach Step 1 = 1
        -- 1
    - Ways to reach Step 2 = 2
        -- 1 by 1
        -- 2
    - Ways to reach Step 3 = 3
        -- 1 by 1
        -- 1 then 2
        -- 2 then 1
    - Ways to reach Step 4 = 5
        -- 1, 1, 1, 1
        -- 1, 1, 2
        -- 1, 2, 1 
        -- 2, 1, 1
        -- 2, 2
    - Ways to reach Step 5 = 8
        -- 1, 1, 1, 2
        -- 1, 1, 2, 1
        -- 1, 2, 1, 1
        -- 1, 2, 1, 1
        -- 2, 1, 1, 1
        -- 1, 2, 2
        -- 2, 1, 2
        -- 2, 2, 1

    At this point you're expected to see the following pattern:
    - Ways to reach Step n = Ways to reach Step n-1 + Ways to reach Step n-2

            = n __|
       + n-1 __|
      n-2 __|
    ____|

    Examples:
    3 = 2 + 1
    5 = 3 + 2
    8 = 5 + 3

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 40.36 MB (Beats 6.26% of users with Java)
*/

class Solution {
    public int climbStairs(int n) {
        if (n == 1) {
            return 1;
        }
        int[] ways = new int[n + 1];
        // To reach Step 1 there is only 1 way
        ways[1] = 1;
        // To reach Step 2 there are only two ways: 1 by 1, or 2
        ways[2] = 2;
        // Despite that if n == 1 we're returning 1, we still need to have
        // ways[1] (and ways[2]) data available to calculate ways[3] below
        // Loop from Step 3 to Step n applying the formula
        for (int i = 3; i <= n; i++) {
            ways[i] = ways[i-1] + ways[i-2];
        }
        return ways[n];
    }
}