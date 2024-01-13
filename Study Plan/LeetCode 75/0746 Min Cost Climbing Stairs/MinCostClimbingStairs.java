/*
    Problem
    --------------------------------------------------------------------------------
    746. Min Cost Climbing Stairs
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

    "You can either start from the step with index 0, or the step with index 1."

    We have two options:
    - "Start from the step with index 0", pay that cost, climb one step,
        pay that cost as well.
    - "Start from the step with index 1", pay that cost, climb two steps,
        pay that cost as well.

    --------------------------------------------------------------------------------
    2. Define a Recursive Solution
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

    We need to sum because we have to pay a cost for every step we take.

    Therefore the minimum cost to reach step n will be the cheapest between our
    possible options, taking one step or two steps.

    --------------------------------------------------------------------------------
    3. Memoization/Tabulation
    --------------------------------------------------------------------------------

    Let's approach the problem _bottom-up_ (tabulation)

    - This approach builds a table to store the solutions for all sub-problems
    (reaching every step) based on their size (n).

    - The solution for each step is calculated iteratively based on the previously
    computed solutions at smaller steps.

    We will make use of the price array to store the minimum cost of each option.

    So our base cases will be:

    price[0] = cost[0]
    price[1] = cost[1]

    --------------------------------------------------------------------------------
    4. Build the solution
    --------------------------------------------------------------------------------

    From there, we can apply our solution to calculate the remaining steps,
    starting with the second (step = 2) until step n (steps)

    int one = cost[step] + price[step-1];
    int two = cost[step] + price[step-2];
    price[step] = Math.min(one, two);

    Finally, the latest 2 elements of our record will have minimum costs of the
    previous steps, but we need to return also the cheapest between them.

    Math.min(price[stair-1], price[stair-2])

    --------------------------------------------------------------------------------
    https://leetcode.com/problems/min-cost-climbing-stairs/solutions/4548497/java-dynamic-programming-step-by-step-beats-100-in-runtime-time-and-space-complexity-o-n/

    - Runtime 0 ms (Beats 100.00% of users with Java)
    - Memory 43.00 MB (Beats 74.02% of users with Java)
*/

class Solution {
    public int minCostClimbingStairs(int[] cost) {
        int stairs = cost.length;
        if (stairs == 1) return cost[0];
        int[] price = new int[stairs];
        price[0] = cost[0];
        price[1] = cost[1];
        for (int step = 2; step < stairs; step++) {
            int one = cost[step] + price[step-1];
            int two = cost[step] + price[step-2];
            price[step] = Math.min(one, two);
        }
        return Math.min(price[stairs-1], price[stairs-2]);
    }
}
