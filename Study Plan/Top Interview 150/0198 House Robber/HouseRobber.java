/* 
    Problem
    --------------------------------------------------------------------------------
    198. House Robber
*/

/* 
    Solution
    --------------------------------------------------------------------------------
    Taking into account the Topics and Hints provided, a Dynamic Programming
    approach is expected for this solution.
    --------------------------------------------------------------------------------
    Dynamic Programming (DP):

    An algorithmic paradigm for solving optimization problems.
    It works by breaking down a problem into smaller, overlapping subproblems,
    solving each subproblem only once, and storing the results for future reuse.
    This avoids redundant calculations and improves efficiency.

    Key Steps:

    - Identify Overlapping Subproblems: Recognize that the problem can be
      divided into smaller, overlapping subproblems.

    - Define a Recursive Solution: Express the solution to the problem in terms
      of the solutions to its subproblems.

    - Memoize or Tabulate Solutions: Store the solutions to subproblems to avoid
      recalculation.

    - Construct the Optimal Solution: Build the overall solution from the saved
      subproblem solutions.

    --------------------------------------------------------------------------------
    Identify Overlapping Subproblems
    --------------------------------------------------------------------------------
    "Adjacent houses have security systems connected and it will automatically
    contact the police if two adjacent houses were broken into on the same night."
    --------------------------------------------------------------------------------
    Define a Recursive Solution
    --------------------------------------------------------------------------------
    Keeping in mind the "adjacent houses" rule, to have reached any house n along
    the street, we must either:

    - Have robbed house n (and also n-2) but not house n-1, or

     n-2     n-1      n
      ^       ^       ^
    /   \   / $ \   /   \
    | _ |   | _ |   | _ |

    - Have not robbed house n, but have robbed n-1.

     n-2     n-1      n
      ^       ^       ^
    / $ \   /   \   / $ \
    | _ |   | _ |   | _ |

    Therefore the maximum possible amount of money must be the higher amount
    between our two options, n + n-2 or n-1
    --------------------------------------------------------------------------------
    Memoize or Tabulate Solutions
    --------------------------------------------------------------------------------
    We will make use of the money array to store the maximum amount of each option.

    Let's approach the problem bottom-up (tabulation),
    So our base cases will be:

    money[0] = nums[0];
    money[1] = Math.max(nums[0], nums[1]);

    From there, we can apply our recursive solution to calculate the remaining
    houses, starting with the third (house = 2) until house n (street)

    money[house] = Math.max(money[house-2] + nums[house], money[house-1]);

    Given nums = [ 2, 7, 3, 1, 4, 2, 1, 8 ]

    For house = 2
      0       1       2
    ---------------------
      ^       ^       ^
    /   \   /   \   /   \
    | 2 |   | 7 |   | 3 |
    ---------------------
    ( $ )   ( $ )   ( $ )
      2       7       ?
    ---------------------
    Math.max(money[0] + nums[2], money[1])
    Math.max(   2     +    3   ,    7    )
    Math.max(         5        ,    7    )

    For house = 3
      0       1       2       3
    -----------------------------
      ^       ^       ^       ^
    /   \   /   \   /   \   /   \
    | 2 |   | 7 |   | 3 |   | 1 |
    -----------------------------
    ( $ )   ( $ )   ( $ )   ( $ )
      2       7       7       ?       
    -----------------------------
    Math.max(money[1] + nums[3], money[2])
    Math.max(   7     +    1   ,    7    )
    Math.max(         8        ,    7    )

    Finally, the latest 2 elements of our record will have maximum amounts,
    but we need to return also the higher between them.
    --------------------------------------------------------------------------------
    https://leetcode.com/problems/house-robber/solutions/4529759/java-dynamic-programming-step-by-step-time-and-space-complexity-0-n-runtime-0ms-beats-100/
    
    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 41.22 MB (Beats 6.95% of users with Java)
*/

class Solution {
    public int rob(int[] nums) {
        int street = nums.length;
        if (street < 2) return nums[0];
        if (street == 2) return Math.max(nums[0], nums[1]);
        int[] money = new int[street];
        money[0] = nums[0];
        money[1] = Math.max(nums[0], nums[1]);
        for (var house = 2; house < street; house++) {
            money[house] = Math.max(money[house-2] + nums[house], money[house-1]);
        }
        return Math.max(money[money.length-1], money[money.length-2]);
    }
}
