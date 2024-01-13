/*  
    Problem
    --------------------------------------------------------------------------------
    70. Climbing Stairs
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Taking into account the Topics and Hints provided, a Dynamic Programming
    approach is expected for this solution.

    Dynamic programming (DP) is a powerful technique for solving optimization
    problems by breaking them down into smaller, overlapping sub-problems and
    storing the solutions for future use.
    Here are the key steps involved in the DP approach:

    1. Identify overlapping sub-problems: Analyze the problem and see if it can
    be decomposed into smaller, independent sub-problems. These sub-problems
    should have some overlap, meaning their solutions contribute to the overall
    solution in multiple ways.

    2. Define a recursive solution: Formulate a recursive function that solves
    the entire problem by breaking it down into smaller sub-problems using the
    identified decomposition. This function should call itself with smaller
    inputs until it reaches base cases where the solution is straightforward.

    3. Memoization/Tabulation: Implement a mechanism to store the solutions of
    these sub-problems as they are computed. This avoids redundant computations
    and significantly improves efficiency. Memoization stores solutions based on
    the specific inputs used, while tabulation builds a table of solutions for
    all possible sub-problems based on their size or relevant parameters.

    4. Build the solution: Use the stored solutions (from memoization or
    tabulation) to build the solution for the overall problem.

    Here are some additional points to remember:

    - Identifying overlapping sub-problems is crucial for successful DP 
    application. Not all problems have this characteristic, and applying DP to
    inappropriate problems can lead to worse performance compared to direct
    solutions.

    - Choosing the right data structure for memoization or tabulation depends on
    the nature of the sub-problems and their relationships. Arrays, hash tables,
    and other structures can be used depending on the specific case.
    
    - Visualization tools and diagrams can be helpful in understanding the
    decomposition and solution construction process in DP.

    --------------------------------------------------------------------------------
    1. Identify overlapping sub-problems
    --------------------------------------------------------------------------------

    "Each time you can either climb 1 or 2 steps."

    - Ways to reach Step 1 = 1
        - 1
    - Ways to reach Step 2 = 2
        - 1 by 1
        - 2
    - Ways to reach Step 3 = 3
        - 1 by 1
        - 1 then 2
        - 2 then 1
    - Ways to reach Step 4 = 5
        - 1, 1, 1, 1
        - 1, 1, 2
        - 1, 2, 1
        - 2, 1, 1
        - 2, 2
    - Ways to reach Step 5 = 8
        - 1, 1, 1, 2
        - 1, 1, 2, 1
        - 1, 2, 1, 1
        - 1, 2, 1, 1
        - 2, 1, 1, 1
        - 1, 2, 2
        - 2, 1, 2
        - 2, 2, 1

    --------------------------------------------------------------------------------
    2. Define a recursive solution
    --------------------------------------------------------------------------------
    
    To have reached any step (n) we must either:
    
    - Have climbed 1 step from the penultimate step (n-1), or

    1 step
               +  n
          n-1 ____|
        ____ |

    - Have climbed 2 steps from the antepenultimate step (n-2)

    2 steps
               +  n
              ____|
    n-2 ____ |

    Therefore: ways to reach step n = ways to reach step n-1 + ways to reach step n-2
    n steps
            = n __|
       + n-1 __|
      n-2 __|
    ____|

    - Examples:

    3 = 2 + 1
    5 = 3 + 2
    8 = 5 + 3

    --------------------------------------------------------------------------------
    3. Memoization/Tabulation
    --------------------------------------------------------------------------------

    Let's approach the problem _bottom-up_ (tabulation)

    - This approach builds a table to store the solutions for all sub-problems
    (reaching every step) based on their size (n).

    - The solution for each step is calculated iteratively based on the previously
    computed solutions at smaller steps.

    We will make use of the ways array to store in how many distinct ways we
    can climb the staircase. So our base cases will be:

    ways[0] = 1;
    ways[1] = 1;
    
    --------------------------------------------------------------------------------
    4. Build the solution
    --------------------------------------------------------------------------------

    From there, we can apply our solution to calculate the remaining steps,
    starting with the second (step = 2) until step n (steps)

    ways[step] = ways[step-1] + ways[step-2];

    --------------------------------------------------------------------------------
    https://leetcode.com/problems/climbing-stairs/solutions/4436816/java-dynamic-programming-step-by-step-beats-100-in-runtime-time-and-space-complexity-o-n/

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 40.36 MB (Beats 6.26% of users with Java)
*/

class Solution {
    public int climbStairs(int n) {
        int steps = n;
        if (steps == 1) return 1;
        var ways = new int[steps + 1];
        ways[0] = 1;
        ways[1] = 1;
        for (int step = 2; step <= steps; step++) {
            ways[step] = ways[step-1] + ways[step-2];
        }
        return ways[steps];
    }
}